using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsSeat
    {
        private string house_seatID=null;
        private string seat_name=null;
        private string seat_remark = null;

        public string id
        {
            get { return house_seatID; }
            set { house_seatID = value; }
        }

        public string name
        {
            get { return seat_name; }
            set { seat_name = value; }
        }

        public string remark
        {
            get { return seat_remark; }
            set { seat_remark = value; }
        }
    }
}
