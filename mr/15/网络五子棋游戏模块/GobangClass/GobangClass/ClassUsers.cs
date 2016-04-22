using System;
using System.Collections.Generic;
using System.Text;

namespace GobangClass
{
    /// <summary>
    /// 记录多人的信息
    /// </summary>
    [Serializable]
    public class ClassUsers : System.Collections.CollectionBase
    {
        public ClassUsers()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public void add(ClassUserInfo userInfo)
        {
            base.InnerList.Add(userInfo);
        }

        public void Romove(ClassUserInfo userInfo)
        {
            base.InnerList.Remove(userInfo);
        }

        public ClassUserInfo this[int index]
        {
            get
            {
                return ((ClassUserInfo)List[index]);
            }
            set
            {
                List[index] = value;
            }
        }
    }
}
