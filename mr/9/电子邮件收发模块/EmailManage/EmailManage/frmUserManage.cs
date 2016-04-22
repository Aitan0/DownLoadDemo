using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EmailManage.CommonClass;

namespace EmailManage
{
    public partial class frmUserManage : Form
    {
        public frmUserManage()
        {
            InitializeComponent();
        }
        Database database = new Database();
        DataSet ds;
        private void frmUserManage_Load(object sender, EventArgs e)
        {
            lviewBind();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("���䲻��Ϊ�գ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ds = database.getDs("select * from tb_User where Email='" + txtName.Text + "'", "tb_User");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("�������Ѿ����ڣ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (database.validateEmail(txtName.Text))
                    {
                        database.getCom("insert into tb_User (Name,Email,Pwd) values('" + txtName.Text.Substring(0, txtName.Text.IndexOf("@")) + "','" + txtName.Text + "','" + txtPwd.Text + "')");
                        MessageBox.Show("�û���Ϣ��ӳɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("��������ȷ�������ַ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    lviewBind();
                    txtName.Text = txtPwd.Text = string.Empty;
                    txtName.Focus();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty && txtPwd.Text == string.Empty)
            {
                MessageBox.Show("��������벻��Ϊ�գ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                database.getCom("update tb_User set pwd ='" + txtPwd.Text + "' where Email='" + txtName.Text + "'");
                MessageBox.Show("�û���Ϣ�޸ĳɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lviewBind();
                txtName.Text = txtPwd.Text = string.Empty;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                if (txtName.Text.ToLower() == "mr@163.com")
                {
                    MessageBox.Show("���û��ǳ����û�������ɾ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    database.getCom("delete from tb_User where Email='" + txtName.Text + "'");
                    MessageBox.Show("�û���Ϣɾ���ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lviewBind();
                }
            }
            else
            {
                MessageBox.Show("��ѡ��Ҫɾ�����û���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lview_Click(object sender, EventArgs e)
        {
            if (lview.Items.Count > 0)
            {
                ds = database.getDs("select * from tb_User where Name='" + lview.SelectedItems[0].Text + "'", "tb_User");
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtPwd.Text = ds.Tables[0].Rows[0][3].ToString();
            }
        }
        private void lviewBind()
        {
            lview.Items.Clear();
            ds = database.getDs("select Name from tb_User", "tb_User");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem lvItem = new ListViewItem(dr[0].ToString(), 0);
                lvItem.SubItems.Add(dr[0].ToString());
                lview.Items.Add(lvItem);
            }
        }
    }
}