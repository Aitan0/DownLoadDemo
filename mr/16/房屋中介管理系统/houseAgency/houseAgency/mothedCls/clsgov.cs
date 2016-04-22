using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsgov
    {
        private string gov_id=null;
        private string gov_name=null;
        private string gov_remark = null;

        public string id
        {
            get { return gov_id; }
            set { gov_id = value; }
        }

        public string name
        {
            get { return gov_name; }
            set { gov_name = value; }
        }

        public string remark
        {
            get { return gov_remark; }
            set { gov_remark = value; }
        }
    }
}
