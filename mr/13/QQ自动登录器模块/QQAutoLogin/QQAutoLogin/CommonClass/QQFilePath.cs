using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace QQAutoLogin.CommonClass
{
    public sealed class QQFilePath
    {
        private static List<QQInfo> qqInfoList = null;//定义一个泛型集合，用来记录QQ账号列表

        /// <summary>
        /// 获取QQ账号列表
        /// </summary>
        /// <param name="path">XML文件路径</param>
        /// <returns>QQ账号列表</returns>
        public static List<QQInfo> GetQQList(string path)
        {
            if (qqInfoList == null)//判断列表是否为空
            {
                FileStream FStream = null;//初始化一个文件流对象
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QQInfo>));//实例化XML文件序列化流
                    FStream = new FileStream(path, FileMode.Open, FileAccess.Read);//实例化文件流对象
                    qqInfoList = (List<QQInfo>)xmlSerializer.Deserialize(FStream);//将文件流中的数据反序列化，并存储到泛型集合中
                    FStream.Close();//关闭文件流
                    return qqInfoList;//返回得到的QQ账号列表
                }
                catch
                {
                    if (FStream != null)//判断文件流是否为空
                        FStream.Close();//关闭文件流
                    return null;//返回空值
                }
            }
            else
            {
                return qqInfoList;//返回得到的QQ账号列表
            }
        }

        /// <summary>
        /// 将QQ账号列表中的数据写入到XML文件
        /// </summary>
        /// <param name="path">XML文件</param>
        /// <param name="qqList">QQ账号列表</param>
        public static void SetQQList(string path, List<QQInfo> qqList)
        {
            if (qqList == null)//判断QQ账号列表是否为空
                throw new Exception("QQ列表为空!");
            FileStream FStream = null;//初始化一个文件流对象
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QQInfo>));//实例化XML文件序列化流
                FStream = new FileStream(path, FileMode.Create, FileAccess.Write);//实例化文件流对象
                xmlSerializer.Serialize(FStream, qqList);//对QQ账号列表中的数据进行序列化，并写入到XML文件
                FStream.Close();//关闭文件流
            }
            catch
            {
                if (FStream != null)//判断文件流是否为空
                    FStream.Close();//关闭文件流
                throw new Exception("XML文件序列化失败!");
            }
        }
    }
}
