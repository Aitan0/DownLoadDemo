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
    public partial class frmTel : Form
    {
        public frmTel()
        {
            InitializeComponent();
        }
        //ʵ�������������
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();


        //�������ʱ�������Զ��巽����ʾ������ϵ��
        public void frmTel_Load(object sender, EventArgs e)
        {
            SetTelData();
        }

        //ִ��ɾ����ϵ�˲���
        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��ɾ����", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string id = dgvAllUser.SelectedCells[0].Value.ToString();
                connclass.getCmd("delete from tb_tel where ID=" + id);
                MessageBox.Show("ɾ����ϵ�˳ɹ�");
                SetTelData();
            }
        }

        //�رյ�ǰ����
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //˫���鿴��ϵ����ϸ��Ϣ���޸�
        private void dgvAllUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Name = this.dgvAllUser.SelectedCells[1].Value.ToString();
            string Type = this.dgvAllUser.SelectedCells[2].Value.ToString();
            string Num = this.dgvAllUser.SelectedCells[3].Value.ToString();
            frmAddUser frmadduser = new frmAddUser();
            frmadduser.LinkmanName = Name;
            frmadduser.Type = Type;
            frmadduser.Num = Num;
            frmadduser.Text = "�޸���ϵ��";
            frmadduser.ShowDialog();
        }

        #region ��DataGridView�ؼ��������ݰ󶨣���ʾ������ϵ��
        /// <summary>
        /// ��DataGridView�ؼ��������ݰ󶨣���ʾ������ϵ��
        /// </summary>
        private void SetTelData()
        {
            DataSet ds = connclass.geDs("select * from tb_tel order by ID desc");
            dgvAllUser.DataSource = ds.Tables[0];
        }
        #endregion
    }
}