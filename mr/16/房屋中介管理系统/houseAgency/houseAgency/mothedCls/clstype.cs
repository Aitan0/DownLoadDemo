using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clstype
    {
        private string huose_typeID=null;
        private string type_name=null;
        private string type_remark = null;

        public string id
        {
            get { return huose_typeID; }
            set { huose_typeID = value; }
        }

        public string name
        {
            get { return type_name; }
            set { type_name = value; }
        }

        public string remark
        {
            get { return type_remark; }
            set { type_remark = value; }
        }
    }
}
