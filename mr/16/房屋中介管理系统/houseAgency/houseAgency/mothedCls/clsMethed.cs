using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsMethed
    {
        private string house_mothedID=null;
        private string mothed_name=null;
        private string mothed_remark = null;

        public string id
        {
            get { return house_mothedID; }
            set { house_mothedID = value; }
        }

        public string name
        {
            get { return mothed_name; }
            set { mothed_name = value; }
        }

        public string remark
        {
            get { return mothed_remark; }
            set { mothed_remark = value; }
        }

    }
}
