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
    public partial class frmResvice : Form
    {
        public frmResvice()
        {
            InitializeComponent();
        }
        #region ���幫��������ʵ�������������
        public static string jcom;
        public static string btl;
        public string power = "YIWU-IJDD-CDQW-JDWG";
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        #endregion

        //�������ʱ����ʾ���յ������ж�����Ϣ
        private void frmResvice_Load(object sender, EventArgs e)
        {
            jcom=BaseClass.GSM.GSMModemGetDevice();����     //�ãϣͣ�
            btl = BaseClass.GSM.GSMModemGetBaudrate();��    //������
            //�����豸
            if (BaseClass.GSM.GSMModemInitNew(jcom, btl, null, null, false, power) == false)
            {
                MessageBox.Show("�豸����ʧ��!" + BaseClass.GSM.GSMModemGetErrorMsg(), "��ʾ", MessageBoxButtons.OK);
                return;
            }
            string smscontent = BaseClass.GSM.GSMModemSMSReadAll(1);
            if (smscontent==null)
            {
                MessageBox.Show("��ʱû���µ���Ϣ��", "ϵͳ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DelData();
                string newstr = smscontent.Replace("||", "#");
                string[] scontent = newstr.Split('#');
                string smscon = "";
                for (int i = 0; i < scontent.Length; i++)
                {
                    smscon = scontent[i];
                    string[] a = smscon.Split('|');
                    string b = "";
                    b = a[0].ToString();
                    if (b.Length < 11&&smscon!="")
                    {
                        string smsstr = b;
                        string smscot = scontent[i].Substring(b.Length, scontent[i].Length - b.Length).Replace("|", "");
                        AddData(smsstr, smscot);
                    }
                    else
                    {
                        if (smscon != "")
                        {
                            if (scontent[i].Substring(0, 1) == "|")
                            {
                                string smsstr = scontent[i].Substring(3, scontent[i].Length - 3).Substring(0, 11);
                                string smscot = scontent[i].Substring(14, scontent[i].Length - 14).Replace("|", "");
                                AddData(smsstr, smscot);
                            }
                            else
                            {
                                string smsstr = scontent[i].Substring(2, scontent[i].Length - 2).Substring(0, 11);
                                string smscot = scontent[i].Substring(13, scontent[i].Length - 13).Replace("|", "");
                                AddData(smsstr, smscot);
                            }
                        }
                    }
                }
                GetData();
            }
        }

        //�鿴������ϸ��Ϣ
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvResvice.SelectedCells[0].Value.ToString();
            string snum = dgvResvice.SelectedCells[1].Value.ToString();
            string stxt = dgvResvice.SelectedCells[2].Value.ToString();
            frmSmsXX smsxx = new frmSmsXX();
            smsxx.Did = id;
            smsxx.Dnum = snum;
            smsxx.Dcontent = stxt;
            smsxx.Show();
        }

        #region ��Ӷ�����Ϣ�����ձ���
        /// <summary>
        /// ��Ӷ�����Ϣ���ձ���
        /// </summary>
        /// <param name="num">���ź���</param>
        /// <param name="content">��������</param>
        private void AddData(string num, string content)
        {
            connclass.getCmd("insert into tb_Resvice([smsnum],[smscontent]) values('" + num + "','" + content + "')");
        }
        #endregion

        #region ɾ��������Ϣ
        /// <summary>
        /// ɾ��������Ϣ
        /// </summary>
        private void DelData()
        {
            connclass.getCmd("delete from tb_Resvice");
        }
        #endregion

        #region �õ����ж�����Ϣ
        /// <summary>
        /// �õ����ж�����Ϣ
        /// </summary>
        private void GetData()
        {
            DataSet ds=connclass.geDs("select * from tb_Resvice order by ID DESC");
            dgvResvice.DataSource = ds.Tables[0];
        }
        #endregion
    }
}