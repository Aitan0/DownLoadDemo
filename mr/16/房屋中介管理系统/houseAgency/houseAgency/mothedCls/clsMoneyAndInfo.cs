using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsMoneyAndInfo
    {
        string moeny_ID=null;
        public string MID
        {
            get{return moeny_ID;}
            set{moeny_ID=value;}
        }
        float Pay_Moeny=0.0f;
        public float PM
        {
            get{return Pay_Moeny;}
            set{Pay_Moeny=value;}
        }
        string emp_ID=null;
        public string EID
        {
            get{return emp_ID;}
            set{emp_ID=value;}
        }
        string emp_name=null;
        public string EName
        {
            get{return emp_name;}
            set{emp_name=value;}
        }
        string house_ID=null;
        public string HID
        {
            get{return house_ID;}
            set{house_ID=value;}
        }
        DateTime Pay_date;
        public DateTime Pday
        {
            get{return Pay_date;}
            set{Pay_date=value;}
        }
        string moeny_remark	=null;
        public string Mark
        {
            get { return moeny_remark; }
            set { moeny_remark = value; }
        }
        string lend_ID=null;
        public string LID
        {
            get { return lend_ID; }
            set { lend_ID = value; }
        }
        string lend_Name=null;
        public string LName
        {
            get { return lend_Name; }
            set { lend_Name = value; }
        }
        string lend_Phone=null;
        public string LPhone
        {
            get { return lend_Phone; }
            set { lend_Phone = value; }
        }
        string want_ID=null;
        public string WID
        {
            get { return want_ID; }
            set { want_ID = value; }
        }
        string want_Name=null;
        public string WName
        {
            get { return want_Name; }
            set { want_Name = value; }
        }
        string want_Phone = null;
        public string Wphone
        {
            get { return want_Phone; }
            set { want_Phone = value; }
        }
    }
}
