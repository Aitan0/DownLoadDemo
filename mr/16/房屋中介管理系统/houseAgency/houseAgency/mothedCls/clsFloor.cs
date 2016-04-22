using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsFloor
    {

        private string house_floorID=null;
        private string floor_name=null;
        private string floor_remark = null;

        public string id
        {
            get { return house_floorID; }
            set { house_floorID = value; }
        }

        public string name
        {
            get { return floor_name; }
            set { floor_name = value; }
        }

        public string remark
        {
            get { return floor_remark; }
            set { floor_remark = value; }
        }
    }
}
