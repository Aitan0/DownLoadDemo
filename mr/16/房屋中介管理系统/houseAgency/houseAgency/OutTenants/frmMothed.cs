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
    public partial class frmMothed : Form
    {            
        string M_Str_tempt = string.Empty;
        ClsCon con = new ClsCon();
        public frmMothed()
        {
            InitializeComponent();
        }

        private void frmMothed_Load(object sender, EventArgs e)
        {
                fillTree();
        }

        #region //method
        private void fillTree()
        {
            this.treeView1.Nodes.Clear();
            DataTable dtResult = new DataTable();
            con.ConDatabase();
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_mothed", con.conn);
            da.Fill(dtResult);
            TreeNode tnMain = new TreeNode("用途设定", 0, 1);
            for (int iRows = 0; iRows < dtResult.Rows.Count; iRows++)
            {
                TreeNode tnChild = new TreeNode(dtResult.Rows[iRows][1].ToString(), 2, 3);
                tnMain.Nodes.Add(tnChild);
            }
            this.treeView1.Nodes.Add(tnMain);
            this.treeView1.Nodes[0].ExpandAll();
        }

        private void ShowInfo(string strNode)
        {
            if (strNode != "用途设定")
            {
                SqlCommand cmd = new SqlCommand("select * from tb_mothed where mothed_name='" + strNode + "'", con.conn);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.textBox1.Text = dr[0].ToString();
                    this.textBox2.Text = dr[1].ToString();
                    this.richTextBox1.Text = dr[2].ToString();

                }
                dr.Close();
                con.closeCon();
            }
        }


        private string strid()
        {
            SqlCommand cmd = new SqlCommand("select Max(house_mothedID) from tb_mothed", con.conn);
            cmd.Connection.Open();
            string strResult = cmd.ExecuteScalar().ToString();
            con.closeCon();
            if (strResult == "")
            {
                strResult = "mot1001";
            }
            else
            {
                int temp = Convert.ToInt32(strResult.Substring(3)) + 1;
                strResult = "mot" + temp;
            }
            return strResult;

        }

        #endregion

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            string strNodeText = e.Node.Text.ToString();
            this.ShowInfo(strNodeText);
        }

        private void tb_add_Click(object sender, EventArgs e)
        {
            M_Str_tempt = "add";

            this.textBox2.Enabled = true;
            this.richTextBox1.Enabled = true;
            this.richTextBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.textBox1.Text = strid();
        }

        private void tb_update_Click(object sender, EventArgs e)
        {
            M_Str_tempt = "update";
            this.textBox2.Enabled = true;
            this.richTextBox1.Enabled = true;
        }

        private void tb_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsMethed cf = new clsMethed();
                clsMethedMethod cm = new clsMethedMethod();
                cf.id = this.textBox1.Text.Trim().ToString();
                if (cm.delete_table(cf))
                    MessageBox.Show("ok");
                else
                    MessageBox.Show("error");
                this.fillTree();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsMethed cf = new clsMethed();
            clsMethedMethod cfm = new clsMethedMethod();
            cf.id = this.textBox1.Text.ToString();
            cf.name = textBox2.Text.ToString();
            cf.remark = richTextBox1.Text.ToString();

            //上面是进行附值
            if (M_Str_tempt == "add")
            {
                string strResult = cfm.insert_table(cf);
                if (strResult == "ok")
                    MessageBox.Show("ok");
                else
                    MessageBox.Show(strResult);
                M_Str_tempt = string.Empty;
            }

            else if (M_Str_tempt == "update")
            {

                if (cfm.update_table(cf))
                    MessageBox.Show("Ok");
                else
                    MessageBox.Show("Error");
                M_Str_tempt = string.Empty;
            }
            else
            {
                MessageBox.Show("请选取有效操作");
            }

            this.fillTree();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tp_OK_Click(object sender, EventArgs e)
        {
            this.button2.PerformClick();
        }

        private void tp_cancel_Click(object sender, EventArgs e)
        {
            this.button1.PerformClick();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strNodeText = e.Node.Text.ToString();
            this.ShowInfo(strNodeText);
        }

       
    }
}