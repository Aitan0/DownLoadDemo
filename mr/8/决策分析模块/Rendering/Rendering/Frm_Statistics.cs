using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rendering
{
    public partial class Frm_Statistics : Form
    {
        public Frm_Statistics()
        {
            InitializeComponent();
        }

        #region  ��������
        ModuleClass.FrmClass FClass = new ModuleClass.FrmClass();
        ModuleClass.DataClass DClass = new ModuleClass.DataClass();
        public DataSet ProDSet = new DataSet();
        #endregion

        private void Frm_Statistics_Shown(object sender, EventArgs e)
        {
            FClass.FieldStyle(MyDLL.DataSets, comboBox_Stat, 2);
            FClass.FieldStyle(MyDLL.DataSets, comboBox_Data, 1);

            button_OK.Top = groupBox_Stat.Top + groupBox_Stat.Height + 10;
            button_Cancel.Top = groupBox_Stat.Top + groupBox_Stat.Height + 10;
            this.Height = button_OK.Top + button_OK.Height + 40;
        }

        private void comboBox_Stat_TextChanged(object sender, EventArgs e)
        {
            bool DateShow = false;
            for (int i = 0; i < ModuleClass.FrmClass.YMD.Length; i++)
            {
                if (ModuleClass.FrmClass.YMD[i] == comboBox_Stat.SelectedIndex)
                {
                    DateShow = true;
                    break;
                }
            }
            if (DateShow)
            {
                groupBox_Data.Visible = DateShow;
                button_OK.Top = groupBox_Data.Top + groupBox_Data.Height + 10;
                button_Cancel.Top = groupBox_Data.Top + groupBox_Data.Height + 10;

                DataSet Dset = DClass.getDataSet("select distinct year(LB_Luna." + comboBox_Stat.Text.Trim() + ") as '���'  from (" + MyDLL.DataSele + ") as LB_Luna", "");
                comboBox_Year.Items.Clear();
                for (int i = 0; i < Dset.Tables[0].Rows.Count; i++)
                {
                    comboBox_Year.Items.Add(Dset.Tables[0].Rows[i][0]);
                }
            }
            else
            {
                groupBox_Data.Visible = DateShow;
                button_OK.Top = groupBox_Stat.Top + groupBox_Stat.Height + 10;
                button_Cancel.Top = groupBox_Stat.Top + groupBox_Stat.Height + 10;
            }
            this.Height = button_OK.Top + button_OK.Height + 40;
        }

        #region  ����ͳ�Ʊ��SQL���
        /// <summary>
        /// ����ͳ�Ʊ��SQL���
        /// </summary>
        /// <returns>����string����</returns>
        public string StatSQL()
        {
            string temSQL = "";
            string StatStr = "";//ͳ���ֶ�
            string DataStr = "";//�����ֶ�
            string logic = "";//��ϵ
            string whereif = "";//�����ؼ���where
            string yearif = "";//������
            string monthif = "";//������
            string groupif = "";//Group by����

            if (comboBox_Stat.Text != "" && comboBox_Data.Text != "")//��ͳ���ֶκ������ֶζ���ֵʱ
            {
                if (groupBox_Data.Visible && (radioButton_Year.Checked == true || radioButton_Month.Checked == true))
                {
                    if (radioButton_Month.Checked == true)
                    {
                        if (comboBox_Year.Text == "")
                        {
                            MessageBox.Show("���Ҫ�Ը��·ݽ���ͳ�ƣ���ѡ���·��������ޡ�");
                            return "";
                        }
                        if (comboBox_Month.Text == "")
                        {
                            StatStr = " month(LB_Luna." + comboBox_Stat.Text.Trim() + ") as " + "'" + comboBox_Stat.Text.Trim() + "(�·�)" + "' ";
                            yearif = " (year(LB_Luna." + comboBox_Stat.Text.Trim() + ")=" + comboBox_Year.Text.Trim() + ") ";
                            groupif = " group by " + " month(LB_Luna." + comboBox_Stat.Text.Trim() + ") ";
                            ModuleClass.FrmClass.AxisX = comboBox_Stat.Text.Trim() + "(�·�)";
                        }
                        else
                        {
                            StatStr = " day(LB_Luna." + comboBox_Stat.Text.Trim() + ") as " + "'" + comboBox_Stat.Text.Trim() + "(��)" + "' ";
                            yearif = " (year(LB_Luna." + comboBox_Stat.Text.Trim() + ")=" + comboBox_Year.Text.Trim() + ") ";
                            logic = " and ";
                            monthif = " (month(LB_Luna." + comboBox_Stat.Text.Trim() + ")=" + comboBox_Month.Text.Trim() + ") ";
                            groupif = " group by " + " day(LB_Luna." + comboBox_Stat.Text.Trim() + ") ";
                            ModuleClass.FrmClass.AxisX = comboBox_Stat.Text.Trim() + "(��)";
                        }
                        whereif = " where ";
                    }
                    if (radioButton_Year.Checked == true)
                    {
                        StatStr = " year(LB_Luna." + comboBox_Stat.Text.Trim() + ") as " + "'" + comboBox_Stat.Text.Trim() + "(���)" + "' ";
                        groupif = " group by " + " year(LB_Luna." + comboBox_Stat.Text.Trim() + ") ";
                        ModuleClass.FrmClass.AxisX = comboBox_Stat.Text.Trim() + "(���)";
                    }

                }
                else
                {
                    StatStr = "LB_Luna." + comboBox_Stat.Text.Trim();
                    groupif = " group by " + "LB_Luna." + comboBox_Stat.Text.Trim();
                    ModuleClass.FrmClass.AxisX = comboBox_Stat.Text.Trim();
                }
                DataStr = " sum(LB_Luna." + comboBox_Data.Text.Trim() + ") as " + comboBox_Data.Text.Trim() + "��� ";
                ModuleClass.FrmClass.AxisY = comboBox_Data.Text.Trim() + "��� ";
                temSQL = "select " + StatStr + "," + DataStr + " from (" + MyDLL.DataSele + ") as LB_Luna " + whereif + yearif + logic + monthif + groupif;
            }
            else
                MessageBox.Show("��ѡ������ͳ�Ʊ������ֶΡ�");
            return temSQL;
        }
        #endregion

        private void button_OK_Click(object sender, EventArgs e)
        {
            string temSql=StatSQL();
            if (temSql.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                ModuleClass.FrmClass.C1 = temSql;
                this.Close();
            }
        }

        private void radioButton_Year_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton_Year.Checked)
            {
                comboBox_Year.Enabled = false;
                comboBox_Month.Enabled = false;
            }
        }

        private void radioButton_Month_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton_Month.Checked)
            {
                comboBox_Year.Enabled = true;
            }
        }

        private void comboBox_Year_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_Year.Text != "")
                comboBox_Month.Enabled = true;
            else
                comboBox_Month.Enabled = false;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}