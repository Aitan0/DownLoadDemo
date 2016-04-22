using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SMS
{
    public partial class frmTelNote : Form
    {
        public frmTelNote()
        {
            InitializeComponent();
        }
        public static string num;//记录选择的手机号码

        //窗体加载时，将数据库中的电话薄记录显示在TreeView控件中
        private void frmTelNote_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from tb_tel", conn);
            OleDbDataReader sdr = cmd.ExecuteReader();
            TreeNode newNode1 = treeView1.Nodes.Add("电话簿");
            newNode1.Checked = true;
            while (sdr.Read())
            {
                newNode1.Nodes.Add(sdr[1].ToString());
            }
            sdr.Close();
            conn.Close();
            treeView1.ExpandAll();
            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        //将在TreeView控件中选择的联系人添加到ListBox控件中
        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "电话簿")
            {
                MessageBox.Show("请选择用户");
                return;
            }
            else
            {
                if (listBox2.Items.Count == 0)
                {
                    listBox2.Items.Add(treeView1.SelectedNode.Text);
                }
                else
                {
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        if (treeView1.SelectedNode.Text == listBox2.Items[i].ToString())
                        {
                            MessageBox.Show("已经添加过了");
                            return;
                        }
                    }
                    listBox2.Items.Add(treeView1.SelectedNode.Text);
                }
            }
        }

        //移除ListBox控件中选择的联系人
        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        //将ListBox中的联系人号码添加到“短信群发”窗体的相应文本框中，并关闭当前窗体
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                AddUser(listBox2.Items[i].ToString());
                frmSendSMS sms = (frmSendSMS)this.Owner;
                sms.lvInceptNum.Items.Add(num);
            }
            this.Close();
        }

        //关闭当前窗体
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 根据指定联系人查找其详细信息
        /// <summary>
        /// 根据指定联系人查找其详细信息
        /// </summary>
        /// <param name="name">联系人名称</param>
        private void AddUser(string name)
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from tb_tel where [UserName]='" + name + "'", conn);
            OleDbDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            num = sdr["UserTel"].ToString();
            conn.Close();
        }
        #endregion
    }
}