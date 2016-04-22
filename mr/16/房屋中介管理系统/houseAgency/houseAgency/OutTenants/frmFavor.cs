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
    /*这里的存储过程写的比较细可以用来参照
     *也用了前台调用输出参数的写法
     **/
    public partial class frmFavor : Form
    {
        claFavorMethod cfm = new claFavorMethod();
        clsFavor cf = new clsFavor();
          
        string M_Str_tempt=string.Empty;
        ClsCon con = new ClsCon();

        public frmFavor()
        {
            InitializeComponent();
        }

        private void frmFavor_Load(object sender, EventArgs e)
        {
            this.fillTree();
        }
      
        #region//DML操作
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
                string strResult = cfm.update_table(cf);
                if (strResult == "ok")
                    MessageBox.Show("ok");
                else
                    MessageBox.Show(strResult);
                M_Str_tempt = string.Empty;
            }
            else
            {
                MessageBox.Show("请选取有效操作");
            }

            this.fillTree();
        }
        #endregion

        #region//method
        private void fillTree()
        {
            try
            {
                this.treeView1.Nodes.Clear();
                DataTable dtResult = new DataTable();
                con.ConDatabase();
                con.closeCon();
                con.conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_favor", con.conn);
                da.Fill(dtResult);
                TreeNode tnMain = new TreeNode("朝向设定", 0, 1);
                for (int iRows = 0; iRows < dtResult.Rows.Count; iRows++)
                {
                    TreeNode tnChild = new TreeNode(dtResult.Rows[iRows][1].ToString(), 2, 3);
                    tnMain.Nodes.Add(tnChild);
                }
                this.treeView1.Nodes.Add(tnMain);
                this.treeView1.Nodes[0].ExpandAll();
            }
            catch { }
        }

        private void ShowInfo(string strNode)
        {
            if (strNode != "朝向设定")
            {
                SqlCommand cmd = new SqlCommand("select * from tb_favor where favor_name='" + strNode + "'", con.conn);
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
            SqlCommand cmd = new SqlCommand("select Max(house_favorID) from tb_favor", con.conn);
            con.closeCon();
            con.conn.Open();
            string strResult = cmd.ExecuteScalar().ToString();
            con.closeCon();
            if (strResult == "")
            {
                strResult = "fav1001";
            }
            else
            {
                int temp = Convert.ToInt32(strResult.Substring(3)) + 1;
                strResult = "fav" + temp;
            }
            return strResult;

        }
        #endregion

        #region//operter
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strNodeText = e.Node.Text.ToString();
            this.ShowInfo(strNodeText);
            
        }

        private void tb_add_Click(object sender, EventArgs e)
        {
            M_Str_tempt = "add";
            this.textBox1.Text = strid();
            textBox2.Enabled = true;
            textBox2.Text = string.Empty;
            richTextBox1.Enabled = true;
            richTextBox1.Text = string.Empty;
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
                string strResult = cfm.delete_table(cf);
                if (strResult == "ok")
                    MessageBox.Show("ok");
                else
                    MessageBox.Show(strResult);
            }
            this.fillTree();
        }

        private void tp_OK_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tp_cancel_Click(object sender, EventArgs e)
        {
            this.button1_Click(sender, e);
        }
        #endregion
    }
}