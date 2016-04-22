using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using houseAgency.mothedCls;

namespace houseAgency
{
    public partial class frmUserLogin : Form
    {
        ClsCon con = new ClsCon();                  //实例化连接对象con
        clsLoginMethed cm = new clsLoginMethed();   //实例化登录记法cm
        clsLogin cl=new clsLogin();                 //实例化登录对象cl
        string ErrorNum = string.Empty;             //记录登录时用户名
        int Num = 0;                                //记录点击次数
        public frmUserLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region//用户与密码是否正确不正确给三次机会然后关闭
         
            cl.LName=this.cobName.Text;
            cl.LPwd = clsMD5Encrypt.GetMD5Password(this.txtPwd.Text.Trim().ToString());
            //cl.LPwd = this.txtPwd.Text.Trim().ToString();
            string power=cm.select_table(cl);
            if (power != "none")
            {
                //调一个方法如果成功进入后台否则记到登录日志中
                frmMain fm = new frmMain();
                this.Hide();
                fm.M_str_Power = this.cobName.Text + "@" + power;
                fm.Show();
            }
            else if(this.txtPwd.Text=="" && this.cobName.Text=="")
            {//当所有信息都没有时这是一个入口
                frmMain fm = new frmMain();
                this.Hide();  
                fm.Show();
            }
            else
            {
                if (ErrorNum == cl.LName)
                {
                    Num += 1;
                    if (Num >= 3)
                    {
                        this.Close();
                    }
                }
                else
                {
                    ErrorNum = cl.LName;
                    Num += 1;
                }
                MessageBox.Show("密码有误,三次后将自动关闭,这是第"+Num+"次");
                this.txtPwd.Text = string.Empty;
                this.txtPwd.Focus();

            }
            #endregion
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.btnLogin.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cobName.SelectedIndex = 0;
            txtPwd.Text = string.Empty;
        }

        private void frmUserLogin_Load(object sender, EventArgs e)
        {
            con.ConDatabase();
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from tb_login", con.conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.cobName.DataSource = dt.DefaultView;
                    cobName.DisplayMember = "login_name";
                }
                catch (Exception ey)
                {
                    MessageBox.Show(ey.Message);
                }
            }
        }  
    }
}