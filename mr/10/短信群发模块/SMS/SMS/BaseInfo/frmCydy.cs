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
    public partial class frmCydy : Form
    {
        public frmCydy()
        {
            InitializeComponent();
        }
        private string str;//��¼��ѡ��Ķ���
        //ʵ�������������
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();

        #region ��DataGridView�ؼ��������ݰ�
        /// <summary>
        /// ��DataGridView�ؼ��������ݰ�
        /// </summary>
        public void BindData()
        {
            DataSet ds = connclass.geDs("select * from tb_note where type='" + str + "'");
            dgvShow.DataSource = ds.Tables[0];
        }
        #endregion

        //�رյ�ǰ����
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ɾ��ѡ�еĶ���
        private void pbDelete_Click(object sender, EventArgs e)
        {
           string id = dgvShow.SelectedCells[0].Value.ToString();
           connclass.getCmd("delete from tb_note where ID=" + id);
           MessageBox.Show("ɾ���ɹ�");
           BindData();
        }

        //��ʾѡ�ж������ϸ��Ϣ
        private void dgvShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.dgvShow.SelectedCells[0].Value.ToString();
            string content = this.dgvShow.SelectedCells[2].Value.ToString();
            string type = tvDy.SelectedNode.Text;
            frmDyChange dychange = new frmDyChange();
            dychange.Scontent = content;
            dychange.Sid = id;
            dychange.Stype = type;
            dychange.ShowDialog();
        }

        //���弤��ʱ��ʾ���ж�����Ϣ
        private void frmCydy_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        //��ʾָ�����Ķ���
        private void tvDy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            str = tvDy.SelectedNode.Text;
            BindData();
        }
    }
}