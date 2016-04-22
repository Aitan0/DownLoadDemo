using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace SMS
{
    public partial class frmSendSMS : Form
    {
        public frmSendSMS()
        {
            InitializeComponent();
        }

        #region ʵ�������������������������
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        public string content;
        public string ResviceNum;
        public static string NUM;
        public static string JQCOM;
        public static string BTL;
        public string Power="YIWU-IJDD-CDQW-JDWG";
        public static int k = 0;
        public static int j = 0;
        #endregion

        //�������ʱ����ȡ����è�Ļ������롢COM�˿ںźͲ�����
        private void frmSendSMS_Load(object sender, EventArgs e)
        {
            txtaddnum.Focus();
            NUM = BaseClass.GSM.GSMModemGetSnInfoNew(JQCOM, BTL);��//��������
            JQCOM = BaseClass.GSM.GSMModemGetDevice();����//�ãϣͣ�
            BTL = BaseClass.GSM.GSMModemGetBaudrate();����//������
        }

        //�жϡ��ֻ����롱�ı����е������Ƿ�Ϊ����
        private void txtaddnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                MessageBox.Show("����������");
                e.Handled = true;
            }
        }

        //�����Զ��巽��ִ�з��Ͷ��Ų���
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (lvInceptNum.Items.Count > 0)
            {
                if (ckbselect.Checked)
                {
                    content = "�����ѣ�" + txtSmsContent.Text;
                }
                else
                {
                    content = txtSmsContent.Text;
                }
                if (this.lvInceptNum.Items.Count <= 0)
                {
                    MessageBox.Show("�ֻ����벻��Ϊ�գ�", "��ʾ", MessageBoxButtons.OK);
                    this.txtaddnum.Focus();
                    return;
                }
                if (txtSmsContent.Text == "")
                {
                    MessageBox.Show("�������ݲ���Ϊ�գ�", "��ʾ", MessageBoxButtons.OK);
                    txtSmsContent.Focus();
                    return;
                }
                SendSms(JQCOM, BTL);
            }
            else
            {
                MessageBox.Show("��������յĵ绰����");
            }
        }

        //�رյ�ǰ����
        private void btnCancol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //�򿪡�ѡ�����Ի���
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmDy frmd = new frmDy();
            frmd.Owner = this;
            frmd.ShowDialog();
        }

        //ִ������ֻ��������
        private void btnIncept_Click(object sender, EventArgs e)
        {
            if (txtaddnum.Text == "")
            {
                MessageBox.Show("�绰���벻��Ϊ�գ�");
                return;
            }
            else
            {
                if (txtaddnum.Text.Length < 11)
                {
                    MessageBox.Show("�ֻ�����Ϊ11λ");
                    return;
                }
            }
            if (lvInceptNum.Items.Count > 0)
            {
                for (int i = 0; i < lvInceptNum.Items.Count; i++)
                {
                    if (lvInceptNum.Items[i].Text == txtaddnum.Text)
                    {
                        MessageBox.Show("�����Ѿ���ӹ��ˣ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                lvInceptNum.Items.Add(txtaddnum.Text);
                txtaddnum.Text = "";
            }
            else
            {
                lvInceptNum.Items.Add(txtaddnum.Text);
                txtaddnum.Text = "";
            }
        }

        //ɾ���ֻ�����
        private void btnDelIncept_Click(object sender, EventArgs e)
        {
            if (lvInceptNum.Items.Count > 0)
            {
                foreach (ListViewItem it in lvInceptNum.SelectedItems)
                {
                    lvInceptNum.Items.Remove(it);
                }
            }
            else
            {
                MessageBox.Show("û�е绰����");
            }
        }

        //�򿪡�ѡ��绰���롱�Ի���
        private void btnSelTel_Click(object sender, EventArgs e)
        {
            frmTelNote telnote = new frmTelNote();
            telnote.Owner = this;
            telnote.ShowDialog();
        }

        #region �����͵Ķ�����Ϣ��ӵ����ݿ���
        /// <summary>
        /// �����͵Ķ�����Ϣ��ӵ����ݿ���
        /// </summary>
        /// <param name="num">�ֻ� ����</param>
        /// <param name="strcontent">��������</param>
        /// <param name="sendtime">���Ͷ���ʱ��</param>
        private void AddMessage(string num, string strcontent, string sendtime)
        {
            connclass.getCmd("insert into tb_TelSend([TelNum],[TelContent],[TelTime]) values('" + num + "','" + strcontent + "','" + sendtime + "')");
        }
        #endregion

        #region ʹ�ö���è���Ͷ���
        /// <summary>
        /// ʹ�ö���è���Ͷ���
        /// </summary>
        /// <param name="strcom">�˿ں�</param>
        /// <param name="strbtl">������</param>
        private void SendSms(string strcom, string strbtl)
        {
            try
            {
                //�����豸
                if (BaseClass.GSM.GSMModemInitNew(strcom, strbtl, null, null, false, Power) == false)
                {
                    MessageBox.Show("�豸����ʧ��!" + BaseClass.GSM.GSMModemGetErrorMsg(), "��ʾ", MessageBoxButtons.OK);
                    return;
                }
                // ���Ͷ���
                j = lvInceptNum.Items.Count;
                for (int i = 0; i < lvInceptNum.Items.Count; i++)
                {
                    AddMessage(lvInceptNum.Items[i].Text, txtSmsContent.Text, DateTime.Now.ToString());
                    if (BaseClass.GSM.GSMModemSMSsend(null, 8, content, Encoding.Default.GetByteCount(content), lvInceptNum.Items[i].Text, false) == true)
                        k++;
                }
                if (k == j)
                {
                    MessageBox.Show("���ŷ��ͳɹ�!", "��ʾ", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
