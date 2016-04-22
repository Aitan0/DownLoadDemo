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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        #region ʵ������������󲢶��幫������
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        public string LinkmanName;
        public string Type;
        public string Num;
        #endregion

        //�������ʱ�����á��Ա������б��Ĭ��ѡ��Ϊ��һ��
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            if (this.Text == "������ϵ��")
                cbbSex.SelectedIndex = 0;
            else
            {
                txtName.Text = LinkmanName;
                cbbSex.Text = Type;
                txtNum.Text = Num;
                txtName.ReadOnly = true;
                groupBox1.Text = "�޸���ϵ��";
            }
        }

        //�жϡ��绰���ı����е������Ƿ�Ϊ����
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                MessageBox.Show("����������");
                e.Handled = true;
            }
        }

        //ִ�����/�޸���ϵ�˲���
        private void pbSubmit_Click(object sender, EventArgs e)
        {
            if (this.Text == "������ϵ��")
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("����������");
                }
                else
                {
                    if (txtNum.Text.Length < 11)
                    {
                        MessageBox.Show("�绰����λ11λ");
                    }
                    else
                    {
                        DataSet ds = connclass.geDs("select * from tb_tel where [UserName]='" + txtName.Text + "'");
                        if (ds.Tables[0].Rows.Count > 0)
                            MessageBox.Show("����ϵ���Ѿ�����");
                        else
                        {
                            connclass.getCmd("insert into tb_tel([UserName],[UserSex],[UserTel]) values('" + txtName.Text + "','" + cbbSex.SelectedItem.ToString() + "','" + txtNum.Text + "')");
                            MessageBox.Show("������ϵ�˳ɹ�");
                        }
                        txtName.Text = "";
                        txtNum.Text = "";
                    }
                }
            }
            else
            {
                connclass.getCmd("update tb_tel set [UserSex]='" + cbbSex.Text + "',[UserTel]='" + txtNum.Text + "' where [UserName]='" + txtName.Text + "'");
                MessageBox.Show("�޸���ϵ�˳ɹ�");
                this.Hide();
            }
        }

        //����ı���
        private void pbConcel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNum.Text = "";
        }
    }
}