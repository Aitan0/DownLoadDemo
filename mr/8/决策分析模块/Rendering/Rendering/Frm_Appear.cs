using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rendering
{
    public partial class Frm_Appear : Form
    {
        public Frm_Appear()
        {
            InitializeComponent();
        }

        #region  公共变量
        ModuleClass.FrmClass FClass = new ModuleClass.FrmClass();
        ModuleClass.DataClass DClass = new ModuleClass.DataClass();
        public static ComboBox CBos;
        #endregion

        private void Frm_Appear_Shown(object sender, EventArgs e)
        {
            CBos = new ComboBox();
            this.comboBox_Page.Items.Clear();
            this.comboBox_Arrange.Items.Clear();
            this.comboBox_Row.Items.Clear();
            this.comboBox_Data.Items.Clear();
            FClass.FieldStyle(MyDLL.DataSets, CBos, 0);
            FClass.CopyComboBox(CBos, comboBox_Page);
            FClass.CopyComboBox(CBos, comboBox_Arrange);
            FClass.CopyComboBox(CBos, comboBox_Row);
            FClass.FieldStyle(MyDLL.DataSets, comboBox_Data, 1);
        }

        private void comboBox_Page_TextChanged(object sender, EventArgs e)
        {
            FClass.CopyComboBox(CBos, comboBox_Arrange);
            FClass.CopyComboBox(CBos, comboBox_Row);
            FClass.RemoveComboBox(comboBox_Page.Text, "", comboBox_Arrange);
            FClass.RemoveComboBox(comboBox_Page.Text, "", comboBox_Row);
        }

        private void comboBox_Arrange_TextChanged(object sender, EventArgs e)
        {
            FClass.CopyComboBox(CBos, comboBox_Row);
            FClass.RemoveComboBox(comboBox_Arrange.Text, comboBox_Page.Text, comboBox_Row);
        }

        private void comboBox_Row_TextChanged(object sender, EventArgs e)
        {
            FClass.CopyComboBox(CBos, comboBox_Arrange);
            FClass.RemoveComboBox(comboBox_Row.Text, comboBox_Page.Text, comboBox_Arrange);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {

            if (comboBox_Row.Text == "" || comboBox_Arrange.Text == "" || comboBox_Data.Text == "" || comboBox_Stat.Text == "")
                MessageBox.Show("请选择制作透视表的字段");
            else
            {
                ModuleClass.FrmClass.C1 = comboBox_Page.Text.Trim();
                ModuleClass.FrmClass.V1 = "";
                ModuleClass.FrmClass.C2 = comboBox_Row.Text.Trim();
                ModuleClass.FrmClass.AxisX = comboBox_Row.Text.Trim();
                ModuleClass.FrmClass.V2 = "";
                ModuleClass.FrmClass.C3 = comboBox_Arrange.Text.Trim();
                ModuleClass.FrmClass.V3 = "";
                ModuleClass.FrmClass.C4 = comboBox_Data.Text.Trim();
                this.DialogResult = DialogResult.OK;
                if (comboBox_Page.Text != "")
                    this.Tag = 1;
                else
                    this.Tag = 0;

            }
        }

        private void comboBox_Stat_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox_Stat.SelectedIndex)
            {
                case 0:
                    {
                        ModuleClass.FrmClass.C5 = "SUM";
                        break;
                    }
                case 1:
                    {
                        ModuleClass.FrmClass.C5 = "AVG";
                        break;                    
                    }
                case 2:
                    {
                        ModuleClass.FrmClass.C5 = "COUNT";
                        break;
                    }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}