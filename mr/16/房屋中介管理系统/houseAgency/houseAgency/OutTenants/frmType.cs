using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using houseAgency.mothedCls;
using System.Data.SqlClient;

namespace houseAgency
{
    public partial class frmType : Form
    {
        clstype cf = new clstype();
        clstypeMethod cfm = new clstypeMethod();
        string M_Str_tempt = string.Empty;
        ClsCon con = new ClsCon();
        public frmType()
        {
            InitializeComponent();
        }

        #region//对treeView的操作
        private void frmType_Load(object sender, EventArgs e)
        {
            fillTree();
        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strNodeText = e.Node.Text.ToString();
            this.ShowInfo(strNodeText);
        }
        #endregion 

        #region //method
        private void fillTree()
        {
            this.treeView1.Nodes.Clear();
            DataTable dtResult = new DataTable();
            con.ConDatabase();
           
            con.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_type", con.conn);
           
            da.Fill(dtResult);
            TreeNode tnMain = new TreeNode("房型设定", 0, 1);
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
            if (strNode != "房型设定")
            {
                SqlCommand cmd = new SqlCommand("select * from tb_type where type_names='" + strNode + "'", con.conn);
                con.closeCon();
                con.conn.Open();
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
            SqlCommand cmd = new SqlCommand("select Max(huose_typeID) from tb_type", con.conn);
            con.closeCon();
            con.conn.Open();
            string strResult = cmd.ExecuteScalar().ToString();
            con.closeCon();
            if (strResult == "")
            {
                strResult = "typ1001";
            }
            else
            {
                int temp = Convert.ToInt32(strResult.Substring(3)) + 1;
                strResult = "typ" + temp;
            }
            return strResult;

        }

        #endregion

        #region//mark
        private void tb_add_Click(object sender, EventArgs e)
        {
            M_Str_tempt = "add";
          
            this.textBox2.Enabled = true;
            this.richTextBox1.Enabled = true;
            this.richTextBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty; 
            this.textBox1.Text=strid();
        }

        private void tb_update_Click(object sender, EventArgs e)
        {
            M_Str_tempt = "update";
            this.textBox2.Enabled = true;
            this.richTextBox1.Enabled = true;
        }

        private void tb_delete_Click(object sender, EventArgs e)
        {
            cf.id = this.textBox1.Text.ToString();
                if (MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (cfm.delete_table(cf))
                        MessageBox.Show("ok");
                    else
                        MessageBox.Show("error");
                    this.fillTree();
                }
        }
        #endregion

        #region//operter
        private void button2_Click(object sender, EventArgs e)
        {
         
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
        #endregion

        #region//这里用了两种式形来调用button的事件
        private void tp_OK_Click(object sender, EventArgs e)
        {
            this.button2_Click(sender, e);
        }

        private void tp_cancel_Click(object sender, EventArgs e)
        {
            this.button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}