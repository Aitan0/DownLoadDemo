using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsFitment
    {
        private string house_fitmentID=null;
        private string fitment_name=null;
        private string fitment_remark = null;

        public string id
        {
            get { return house_fitmentID; }
            set { house_fitmentID = value; }
        }

        public string name
        {
            get { return fitment_name; }
            set { fitment_name = value; }
        }

        public string remark
        {
            get { return fitment_remark; }
            set { fitment_remark = value; }
        }
    }
}
