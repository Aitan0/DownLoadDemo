using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsUser
    {
        private string User_IDS;
        private string User_names;
        private string User_sex;
        private string User_birth;
        private string User_phone;
        private string User_homePhone;
        private string User_email;
        private string User_cardID;
        private string User_type;
        private string house_ID="none";
        private string User_recordDate;

        public string id
        {
            get { return User_IDS; }
            set { User_IDS = value; }
        }

        public string name
        {
            get { return User_names; }
            set { User_names = value; }
        }

        public string sex
        {
            get { return User_sex; }
            set { User_sex = value; }
        }

        public string birth
        {
            get { return User_birth; }
            set { User_birth = value; }
        }

        public string phone
        {
            get { return User_phone; }
            set { User_phone = value; }
        }

        public string homePhone
        {
            get { return User_homePhone; }
            set { User_homePhone = value; }
        }


        public string email
        {
            get { return User_email; }
            set { User_email = value; }
        }

        public string cardID
        {
            get { return User_cardID; }
            set { User_cardID = value; }
        }

        public string type
        {
            get { return User_type; }
            set { User_type = value; }
        }

        public string hID
        {
            get { return house_ID; }
            set { house_ID = value; }
        }

        public string recordDate
        {
            get { return User_recordDate; }
            set { User_recordDate = value; }
        }

    }
}
