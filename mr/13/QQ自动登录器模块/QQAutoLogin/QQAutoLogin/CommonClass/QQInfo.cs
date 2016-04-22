using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace QQAutoLogin.CommonClass
{
    /// <summary>
    /// QQ账号信息类
    /// </summary>
    [XmlRoot("Root")]
    public class QQInfo
    {
        private string number;//QQ账号字段
        private string pwd;//QQ密码字段
        private string lastLoginTime;//最后登录时间字段
        private bool isHide;//是否隐身字段
        private bool isChecked;//是否选中字段

        /// <summary>
        /// QQ账号
        /// </summary>
        [XmlElement(ElementName = "Number")]
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        /// <summary>
        /// QQ密码
        /// </summary>
        [XmlElement(ElementName = "Pwd")]
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        [XmlElement(ElementName = "LastLoginTime")]
        public string LastLoginTime
        {
            get { return lastLoginTime; }
            set { lastLoginTime = value; }
        }

        /// <summary>
        /// 是否隐身
        /// </summary>
        [XmlElement(ElementName = "IsHide")]
        public bool IsHide
        {
            get { return isHide; }
            set { isHide = value; }
        }

        /// <summary>
        /// 是否选中
        /// </summary>
        [XmlElement(ElementName = "IsChecked")]
        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; }
        }

        /// <summary>
        /// 默认构造函数，为了使该类能够序列化
        /// </summary>
        public QQInfo() { }

        /// <summary>
        /// 初始化QQ账号信息
        /// </summary>
        /// <param name="qqNumber">QQ账号</param>
        /// <param name="qqPwd">QQ密码</param>
        /// <param name="qqLastLoginTime">最后登录时间</param>
        /// <param name="isHide">隐身状态</param>
        /// <param name="isChecked">选中状态</param>
        public QQInfo(string qqNumber, string qqPwd, string qqLastLoginTime, bool isHide, bool isChecked)
        {
            this.number = qqNumber;//初始化QQ账号
            this.pwd = qqPwd;//初始化QQ密码
            this.lastLoginTime = qqLastLoginTime;//初始化最后登录时间
            this.isHide = isHide;//初始化隐身状态
            this.isChecked = isChecked;//初始化选中状态
        }
    }
}
