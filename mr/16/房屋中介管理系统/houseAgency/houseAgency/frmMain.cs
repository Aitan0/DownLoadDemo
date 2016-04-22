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
    public partial class frmMain : Form
    {
        public string M_str_Power = string.Empty;
        string Power = string.Empty;
        public frmMain()
        {
            InitializeComponent();
        }

        #region  ��MenuStrip�ؼ��е���Ϣ��ӵ�treeView�ؼ���
        /// <summary>
        /// ��ȡ�˵��е���Ϣ.
        /// </summary>
        /// <param name="treeV">TreeView�ؼ�</param>
        /// <param name="MenuS">MenuStrip�ؼ�</param>
        public void GetMenu(TreeView treeV, MenuStrip MenuS)
        {
            for (int i = 0; i < MenuS.Items.Count; i++) //����MenuStrip����е�һ���˵���
            {
                //��һ���˵����������ӵ�TreeView����ĸ��ڵ��У������õ�ǰ�ڵ���ӽڵ�newNode1
                TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);
                newNode1.Tag = 0;
                //����ǰ�˵�������������Ϣ���뵽ToolStripDropDownItem������
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                //�жϵ�ǰ�˵������Ƿ��ж����˵���
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)    //���������˵���
                    {
                        //�������˵�������ӵ�TreeView������ӽڵ�newNode1�У������õ�ǰ�ڵ���ӽڵ�newNode2
                        TreeNode newNode2 = newNode1.Nodes.Add(newmenu.DropDownItems[j].Text);
                        newNode2.Tag = int.Parse(newmenu.DropDownItems[j].Tag.ToString());
                        //����ǰ�˵�������������Ϣ���뵽ToolStripDropDownItem������
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                    }
            }
        }
        #endregion

        #region  ��StatusStrip�ؼ��е���Ϣ��ӵ�treeView�ؼ���
        /// <summary>
        /// ��ȡ�˵��е���Ϣ.
        /// </summary>
        /// <param name="treeV">TreeView�ؼ�</param>
        public void frm_show(int n)
        {
            switch (n)//ͨ����ʶ���ø��Ӵ���
            {
                case 0: break;
                case 1:
                    {
                        frmPeopleInfo fp = new frmPeopleInfo();//ʵ����һ��frmPeopleInfo����
                        fp.strID = "want";//���ô����еĹ�������
                        fp.Text = "������Ա��Ϣ";//���ô��������
                        fp.ShowDialog();//��ģ�ԶԻ���򿪴���
                        fp.Dispose();//�ͷŴ����������ԭ
                        break; 
                    }
                case 2:
                    {
                        frmPeopleInfo fp = new frmPeopleInfo();
                        fp.strID = "lend";
                        fp.Text = "������Ա��Ϣ����";
                        fp.ShowDialog();
                        fp.Dispose();
                        break;
                    }
                case 3:
                    {
                        frmPeopleList fp = new frmPeopleList();
                        fp.ShowDialog();
                        fp.Dispose();
                        break;
                    }
                case 4:
                    {
                        frmSelect fs = new frmSelect();
                        fs.ShowDialog();
                        fs.Dispose();
                        break;
                    }
                case 5:
                    {
                        frmStateHouse fs = new frmStateHouse();
                        fs.ShowDialog();
                        fs.Dispose();
                        break;
                    }
                case 6:
                    {
                        frmIntend fi = new frmIntend();
                        fi.ShowDialog();
                        fi.Dispose();
                        break;
                    }
                case 7:
                    {
                        frmEmploeey fe = new frmEmploeey();
                        fe.ShowDialog();
                        fe.Dispose();
                        break;
                    }
                case 8:
                    {
                        frmEmpleeyAll fe = new frmEmpleeyAll();
                        fe.ShowDialog();
                        fe.Dispose();
                        break;
                    }
                case 9:
                    {
                        frmType ft = new frmType();
                        ft.ShowDialog();
                        ft.Dispose();
                        break;
                    }
                case 10:
                    {
                        frmFloor ff = new frmFloor();
                        ff.ShowDialog();
                        ff.Dispose();
                        break;
                    }
                case 11:
                    {
                        frmSeat fs = new frmSeat();
                        fs.ShowDialog();
                        fs.Dispose();
                        break;
                    }
                case 12:
                    {
                        frmFitment ff = new frmFitment();
                        ff.ShowDialog();
                        ff.Dispose();
                        break;
                    }
                case 13:
                    {
                        frmFavor ff = new frmFavor();
                        ff.ShowDialog();
                        ff.Dispose();
                        break;
                    }
                case 14:
                    {
                        frmMothed fm = new frmMothed();
                        fm.ShowDialog();
                        fm.Dispose();
                        break;
                    }
                case 15:
                    {
                        frmMoney fm = new frmMoney();
                        fm.ShowDialog();
                        fm.Dispose();
                        break;
                    }
                case 16:
                    {
                        frmMoneyRemark fmr = new frmMoneyRemark();
                        fmr.ShowDialog();
                        fmr.Dispose();
                        break;
                    }
                case 17:
                    {
                        frmBargin fb = new frmBargin();
                        fb.ShowDialog();
                        fb.Dispose();
                        break;
                    }
                case 21:
                    {
                        //�򿪼��±�
                        System.Diagnostics.Process.Start("notepad.exe");
                        break;
                    }
                case 22:
                    {
                        //�򿪼�����
                        System.Diagnostics.Process.Start("calc.exe");
                        break;
                    }
                case 23:
                    {
                        //��WORD�ĵ�
                        System.Diagnostics.Process.Start("WINWORD.EXE");
                        break;
                    }
                case 24:
                    {
                        //��EXCEL�ļ�
                        System.Diagnostics.Process.Start("EXCEL.EXE");
                        break;
                    }
                case 25:
                    {
                        frmChangYouSelfPwd fcy = new frmChangYouSelfPwd();
                        fcy.M_str_Name = this.tspname.Text.ToString();
                        fcy.ShowDialog();
                        fcy.Dispose();
                        break;
                    }
                case 26:
                    {
                        if (MessageBox.Show("ȷ���˳�ϵͳ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            Application.Exit();//�رյ�ǰ����
                        break;
                    }
                case 27:
                    {
                        frmStock fs = new frmStock();
                        fs.ShowDialog();
                        fs.Dispose();
                        break;
                    }
                case 28:
                    {
                        frmRestore fr = new frmRestore();
                        fr.ShowDialog();
                        fr.Dispose();
                        break;
                    }
                case 29:
                    {
                        ClsCon con = new ClsCon();//ʵ����һ��ClsCon������
                        con.ConDatabase();//�������ݿ�
                        //����һ����������˺ͷ�Դ֮���������Ϣ
                        //�統��������Ҫ���ⷿʱ����û�и�������Դ��Ϣ��ʱ��������Ϣ��û������
                        try
                        {
                            SqlCommand cmd = new SqlCommand();//ʵ����һ��SqlCommand��
                            cmd.Connection = con.conn;//�����ݿ⽨����ϵͳ
                            cmd.Connection.Open();//�����ݿ������
                            cmd.CommandText = "proc_clear";//�洢���̵���
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();//ִ�д洢����
                            con.closeCon();//�ر����ݿ������
                            MessageBox.Show("��ϲ�����������");
                        }
                        catch (Exception ey)
                        {
                            MessageBox.Show(ey.Message);
                        }
                        break;
                    }
                case 30:
                    {
                        //�򿪰����Ի���
                        MessageBox.Show("\t����Ե����տƼ���վ\t\n\n\t  �õ�����֪����\n\t    ллʹ�ã���");
                        break;
                    }
            }
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            //�ڼ���ʱ����Ȩ�޺��û�����Ϣ
            //ͨ�����ַ��������ĵ���
            if (M_str_Power != string.Empty)//��M_str_Power��Ϊ��ʱ��Ҳ���ǵ�¼�ɹ�
            {
                //��ȡ��ǰ��¼���û���
                tspname.Text = M_str_Power.Substring(0, M_str_Power.IndexOf('@'));
                tspLoginTime.Text = DateTime.Now.ToLongTimeString();//��ȡ��ǰϵͳʱ��
                Power = M_str_Power.Substring(M_str_Power.IndexOf('@') + 1);//��ȡ��ǰ���û�Ȩ��
                if (Power == "0")//���û�Ȩ��Ϊ0ʱ
                {
                    this.tbEmpleey.Visible = false;//���ء�Ա����Ϣ���˵�
                }
                else
                {
                    this.tbEmpleey.Visible = true;
                }
                GetMenu(treeView1, menuStrip1);//�����Զ��巽��GetMenu()
            }
        }

        #region//���ù���

        private void ���±�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void eXECELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void wORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        #endregion

        #region//��������
        private void tspClear_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        #endregion

        #region//�˳�����
        private void �˳�ϵͳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        #endregion

        #region//������������


       private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void ¥������ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       

       private void ������Ա��ϢToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void l������Ա��Ϣ����ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }


       private void timer1_Tick(object sender, EventArgs e)
       {
           this.tspNowTime.Text = DateTime.Now.ToLongTimeString();
       }

       private void ���ⷿԴ����ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmHouse fh = new frmHouse();
           fh.ShowDialog();
           fh.Dispose();
       }

       private void tsmHouseType_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void tsmseat_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void tsmZhuang_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void tsmUser_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void ��ҵ��������ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmType ft = new frmType();
           ft.ShowDialog();
           ft.Dispose();
       }
      

       private void tsSelectHouse_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stStateHouse_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void tsmDataStock_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void tsmDataRestore_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

       

        private void tsWantHouse_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void ¼��Ա����ϢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void ����Ա����ϢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void �շ�����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void ����ͳ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void smpbargin_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

      
        private void tmPeoControl_Click(object sender, EventArgs e)
        {
            frmPeopleList fp = new frmPeopleList();
            fp.ShowDialog();
        }
       #endregion

        private void �����ļ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            frm_show(int.Parse(e.Node.Tag.ToString()));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm_show(1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm_show(2);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frm_show(4);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frm_show(16);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frm_show(17);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            frm_show(Convert.ToInt32(e.Node.Tag.ToString()));
        }
    }
}