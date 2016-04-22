using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using EmailManage.CommonClass;

namespace EmailManage
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Database database = new Database();         //实例化公共类对象
        public static jmail.POP3Class popMail;      //实例化POP3类对象
        public static jmail.Message mailMessage;    //实例化邮件对象
        public static jmail.Attachments atts;       //实例化邮件的附件集合
        public static jmail.Attachment att;         //实例化附件对象
        public static string strserver;             //存储邮件服务器
        public static string user;                  //存储用户登录邮箱的用户名
        public static string pwd;                   //存储用户登录邮箱的密码
        public static int index;                    //记录邮件索引
        public static string strFrom;               //记录选中的邮件发送人
        public static string strSubject;            //记录选中的邮件主题
        public static string strBody;               //记录选中的邮件内容
        public static string strAttachment;         //记录选中的邮件附件
        public static string strDate;               //记录选中的邮件发送日期
        //对读取的邮件内容进行Base64编码
        public static string Base64Decode(string str)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //禁用DataGridView控件的排序功能
            for (int i = 0; i < dgvEmailInfo.Columns.Count; i++)
                dgvEmailInfo.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            if (Database.StrName == "mr" || Database.StrName == "mr@163.com")
            {
                用户管理ToolStripMenuItem.Visible = true;
            }
            else
            {
                用户管理ToolStripMenuItem.Visible=false;
            }
            if (Database.StrName.IndexOf("@") == -1)
            {
                DataSet myds = database.getDs("select * from tb_User where Name='" + Database.StrName + "'", "tb_User");
                user = myds.Tables[0].Rows[0][2].ToString();
                pwd = myds.Tables[0].Rows[0][3].ToString();
            }
            else
            {
                user = Database.StrName;
                DataSet myds = database.getDs("select * from tb_User where Email='" + Database.StrName + "'", "tb_User");
                pwd = myds.Tables[0].Rows[0][3].ToString();
            }
            strserver = Dns.GetHostName();
            popMail = new jmail.POP3Class();
            //调用Connect方法连接指定的邮箱
            try
            {
                popMail.Connect(user, pwd, strserver, 110);
                TLabUser.Text = user;
                TLabNum.Text = popMail.Count + " 封";
                if (popMail.Count != 0)
                {
                    dgvEmailInfo.RowCount = popMail.Count;
                    if (popMail != null)
                    {
                        if (popMail.Count > 0)//当邮箱中存在邮件的情况下运行代码
                        {
                            for (int i = 1; i < popMail.Count + 1; i++)
                            {
                                mailMessage = popMail.Messages[i];
                                if (mailMessage.From == user.Trim().ToLower())
                                {
                                    dgvEmailInfo.Rows[i - 1].Cells[0].Value = "我";
                                }
                                else
                                {
                                    dgvEmailInfo.Rows[i - 1].Cells[0].Value = mailMessage.From;
                                }
                                dgvEmailInfo.Rows[i - 1].Cells[1].Value = Base64Decode(mailMessage.Subject);
                                dgvEmailInfo.Rows[i - 1].Cells[2].Value = Base64Decode(mailMessage.Body);
                                dgvEmailInfo.Rows[i - 1].Cells[4].Value = mailMessage.Date.ToString();
                                if (popMail.Count >= 1 && i <= popMail.Count)
                                {
                                    atts = mailMessage.Attachments;
                                    if (atts.Count > 0)
                                    {
                                        dgvEmailInfo.Rows[i - 1].Cells[3].Value = "附件下载";
                                    }
                                    else
                                    {
                                        dgvEmailInfo.Rows[i - 1].Cells[3].Value = "无附件";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    dgvEmailInfo.Rows.Clear();
                }
            }
            catch
            {
                MessageBox.Show("该用户邮箱不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 邮件发送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSend frmsend = new frmSend();
            frmsend.Owner = this;
            frmsend.Show();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManage frmusermanage = new frmUserManage();
            frmusermanage.Owner = this;
            frmusermanage.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                popMail.DeleteSingleMessage(index + 1);
                popMail.Disconnect();
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmailInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
        }

        private void dgvEmailInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    mailMessage = popMail.Messages[e.RowIndex + 1];
                    atts = mailMessage.Attachments;
                    for (int k = 0; k < atts.Count; k++)
                    {
                        att = atts[k];
                        string attname = att.Name;
                        Directory.CreateDirectory("AttachFiles\\" + user);
                        string mailPath = "AttachFiles\\" + user + "\\" + ReplaceName(att.Name);
                        att.SaveToFile(mailPath);
                        MessageBox.Show("下载成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch { }
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = null;
            frmLogin frmlogin = new frmLogin();
            popMail.Disconnect();
            this.Hide();
            frmlogin.Show();
        }

        private void dgvEmailInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            strFrom = strSubject = strBody = strDate = strAttachment = string.Empty;
            strFrom = dgvEmailInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            strSubject = dgvEmailInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            strBody = dgvEmailInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            strDate = dgvEmailInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
            mailMessage = popMail.Messages[e.RowIndex + 1];
            atts = mailMessage.Attachments;
            for (int k = 0; k < atts.Count; k++)
            {
                att = atts[k];
                if (strAttachment == string.Empty)
                    strAttachment = ReplaceName(att.Name);
                else
                    strAttachment += "," + ReplaceName(att.Name);
            }
            frmEmailInfo frmemailinfo = new frmEmailInfo();
            frmemailinfo.ShowDialog();
        }
        /// <summary>
        /// 替换文件名
        /// </summary>
        /// <param name="strName">附件名</param>
        /// <returns>替换后的文件名</returns>
        private string ReplaceName(string strName)
        {
            string strNewName = "";
            strNewName = strName.Replace(strName.Substring(0, strName.LastIndexOf(".") + 1), DateTime.Now.ToString("yyyyMMddhhmmss") + ".");
            return strNewName;
        }
    }
}