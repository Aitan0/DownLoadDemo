using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace houseAgency.mothedCls
{
    class clsEmpleey
    {
        string employee_ID=null;
        string employee_name="";
        string employee_sex="";
        string employee_birthday="0";
        string employee_phone="";	
        string employee_cardID="";
        string employee_address	="";
        string gov_ID="";
        string employee_study="";
        float employee_basepay=0.0f;

        public string eID
        { 
            get { return employee_ID;}
            set{employee_ID=value;}
        }

         public string eName
        { 
             get { return employee_name;}
            set{employee_name =value;}
        }

         public string eSex
        { 
             get { return employee_sex;}
            set{employee_sex =value;}
        }

          public string eDay
        { 
              get { return employee_birthday;}
            set{employee_birthday=value;}
        }

         public string ePhone
        { 
             get { return employee_phone;}
            set{employee_phone=value;}
        }

         public string eIDCard
        { 
             get { return employee_cardID;}
            set{employee_cardID=value;}
        }

          public string eAddress
        { 
              get { return employee_address;}
            set{employee_address=value;}
        }
         public string eGID
        { 
             get { return gov_ID;}
             set{gov_ID=value;}
        }

        public string eStuID
        { 
            get { return employee_study ;}
            set{employee_study=value;}
        }

         public float EPay
        { 
             get { return employee_basepay;}
            set{employee_basepay=value;}
        }
    }
}
