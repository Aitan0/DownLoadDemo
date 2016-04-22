using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class ClsHouse
    {
        string house_ID;
        string house_companyName;	
        string huose_typeID;	
        string house_seatID;	
        string house_state;
        string house_fitmentID;

        string house_favorID;	
        string house_mothedID;	
        string huose_map;
        string house_price;	
        string house_floorID;
        string house_buildYear;		
        string house_area;
        string house_remark;
        string user_ids;

        public string id
        {
            get { return house_ID; }
            set { house_ID = value; }
        }

        public string name
        {
            get { return house_companyName; }
            set { house_companyName = value; }
        }

        public string typeID
        {
            get { return huose_typeID; }
            set { huose_typeID = value; }
        }


        public string seatID
        {
            get { return house_seatID; }
            set { house_seatID = value; }
        }

        public string state
        {
            get { return house_state; }
            set { house_state = value; }
        }

        public string fitmentID
        {
            get { return house_fitmentID; }
            set { house_fitmentID = value; }
        }


        public string favorID
        {
            get { return house_favorID; }
            set { house_favorID = value; }
        }

        public string mothedID
        {
            get { return house_mothedID; }
            set { house_mothedID = value; }
        }

        public string map
        {
            get { return huose_map; }
            set { huose_map = value; }
        }




        public string price
        {
            get { return house_price; }
            set { house_price = value; }
        }

        public string floorID
        {
            get { return house_floorID; }
            set { house_floorID = value; }
        }


        public string buildYear
        {
            get { return house_buildYear; }
            set { house_buildYear = value; }
        }

        public string area
        {
            get { return house_area; }
            set { house_area = value; }
        }

        public string remark
        {
            get { return house_remark; }
            set { house_remark = value; }
        }

        public string urids
        {
            get { return user_ids; }
            set { user_ids = value; }
        }
    }
}
