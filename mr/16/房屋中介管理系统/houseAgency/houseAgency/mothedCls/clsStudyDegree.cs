using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsStudyDegree
    {
        private string studyDegree_ID=null;
        private string studyDegree_name=null;
        private string studyDegree_remark = null;

        public string id
        {
            get { return studyDegree_ID; }
            set { studyDegree_ID = value; }
        }

        public string name
        {
            get { return studyDegree_name; }
            set { studyDegree_name = value; }
        }

        public string remark
        {
            get { return studyDegree_remark; }
            set { studyDegree_remark = value; }
        }
    }
}
