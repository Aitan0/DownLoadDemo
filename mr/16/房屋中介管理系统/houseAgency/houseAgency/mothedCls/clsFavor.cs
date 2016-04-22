using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsFavor
    {
        private string house_favorID=null;
        private string favor_name=null;
        private string favor_remark = null;

        public string id
        {
            get { return house_favorID; }
            set { house_favorID = value; }
        }

        public string name
        {
            get { return favor_name; }
            set { favor_name = value; }
        }

        public string remark
        {
            get { return favor_remark; }
            set { favor_remark = value; }
        }
    }
}
