using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsIntend
    {
        string intent_ID;
        string User_ID;
        string huose_typeID;
        string house_seatID;
        string house_fitmentID;
        string house_floorID;
        string house_favorID;
        string house_mothedID;
        float house_price;
        string house_area;

        public string tend_id
        {
            get { return intent_ID; }
            set { intent_ID = value; }
        }
        public string u_id
        {
            get { return User_ID; }
            set { User_ID = value; }
        }
        public string ty_id
        {
            get { return huose_typeID; }
            set { huose_typeID = value; }
        }
        public string se_ID
        {
            get { return house_seatID; }
            set { house_seatID = value; }
        }
        public string fi_ID
        {
            get { return house_fitmentID; }
            set { house_fitmentID = value; }
        }
        public string fl_ID
        {
            get { return house_floorID; }
            set { house_floorID = value; }
        }
        public string fa_ID
        {
            get { return house_favorID; }
            set { house_favorID = value; }
        }
        public string mo_ID
        {
            get { return house_mothedID; }
            set { house_mothedID = value; }
        }
        public float price
        {
            get { return  house_price;}
            set { house_price = value; }
        }
        public string area
        {
            get { return house_area; }
            set { house_area = value; }
        }

    }
}
