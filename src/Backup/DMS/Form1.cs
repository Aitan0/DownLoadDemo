using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DMS.DomainObjects.BasicInfo;

namespace DMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            //userInfo.ID = 2;
            //userInfo.UserName = "王二小";
            //userInfo.Password = "bbb";
            //userInfo.Question = 3.33f;
            //userInfo.Answer = DateTime.Now;
            //userInfo.Email = 123;

            //userInfo.Update();

            userInfo.Retrieve(2);

            //userInfo = new UserInfo();
            //userInfo.ID = 1;
            //userInfo.Delete();

            List<UserInfo> userInfoList = UserInfo.GetList();
        }
    }
}
