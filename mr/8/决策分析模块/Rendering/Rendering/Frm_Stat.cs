using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rendering
{
    public partial class Frm_Stat : Form
    {
        public Frm_Stat()
        {
            InitializeComponent();
        }

        #region  公共变量
        ModuleClass.FrmClass FClass = new ModuleClass.FrmClass();
        ModuleClass.DataClass DClass = new ModuleClass.DataClass();
        public DataSet ProDSet = new DataSet();
        public static Font TitFont=new Font("宋体",9);
        public static Color TitColor = Color.Black;
        #endregion

        #region  图表属性的综合设置
        private void ChartAttribute()
        {
            FClass.GetChartProperty(chartPanel1, TitFont, Convert.ToInt32(button_Font.Tag.ToString()));
            FClass.GetChartProperty(chartPanel1, TitColor, Convert.ToInt32(button_Color.Tag.ToString()));
            FClass.GetChartProperty(chartPanel1, textBox_Title.Text.Trim(), Convert.ToInt32(button_Title.Tag.ToString()));

            FClass.GetChartProperty(chartPanel1, comboBox_Label.SelectedIndex, Convert.ToInt32(comboBox_Label.Tag.ToString()));
            FClass.GetChartProperty(chartPanel1, comboBox_Tagboard.SelectedIndex, Convert.ToInt32(comboBox_Tagboard.Tag.ToString()));
            FClass.GetChartProperty(chartPanel1, comboBox_Tagboard.SelectedIndex, Convert.ToInt32(comboBox_Tagboard.Tag.ToString()));
            FClass.GetChartProperty(chartPanel1, comboBox_Lattice.SelectedIndex, Convert.ToInt32(comboBox_Lattice.Tag.ToString()));
            FClass.GetChartProperty(chartPanel1, ComboBox_ChartStyle.SelectedIndex, Convert.ToInt32(ComboBox_ChartStyle.Tag.ToString()));
        }
        #endregion

        #region  生成图表
        private void ChartCreate()
        {
            if (ProDSet.Tables[0].Rows.Count > 0)
            {
                chartPanel1.ShowData = true;
                switch (Convert.ToInt32(this.Tag.ToString()))
                {
                    case 1:
                        {
                            chartPanel1.SumAxes = ChartComponent.ChartPanel.AxesStyle.XY;
                            chartPanel1.SumXAxis = ModuleClass.FrmClass.AxisX;
                            chartPanel1.DataSource = ProDSet;
                            break;
                        }
                    case 2:
                        {
                            chartPanel1.SumXAxis = ModuleClass.FrmClass.AxisX;
                            chartPanel1.SumYAxis = ModuleClass.FrmClass.AxisY;
                            chartPanel1.DataSource = ProDSet;
                            break;
                        }
                }
                ChartAttribute();
            }
            else
                chartPanel1.ShowData = false;
        }
        #endregion
         
        private void Frm_Stat_Shown(object sender, EventArgs e)
        {
            ModuleClass.DataClass.M_str_sqlcon = MyDLL.DataCom;
            MyDLL.DataSele = FClass.DataFormat(MyDLL.DataSets, MyDLL.DataSele);
            dataGridView1.DataSource = MyDLL.DataSets.Tables[0];
            ModuleClass.DataClass.OldSQL = MyDLL.DataSele;
            FClass.ProInitialize(comboBox_Label, 1);
            FClass.ProInitialize(comboBox_Tagboard, 0);
            FClass.ProInitialize(comboBox_Whereat, 0);
            FClass.ProInitialize(comboBox_Lattice, 0);
            FClass.ProInitialize(ComboBox_ChartStyle, 0);
            DClass.getDataSet(DClass.DROP_Pro(), "");
            DClass.getDataSet(DClass.RenderingMemory(),"");
            listView1.View = View.Details;//显示列名称
            listView1.Columns.Add("", listView1.Parent.Width - 3, HorizontalAlignment.Center);//设置列标头的名称及大小
            chartPanel1.ShowData = false;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            if (e.ColumnIndex == 0)
                FClass.Data_List(listView1, 0);
            if (e.ColumnIndex > 0 && e.ColumnIndex<dataGridView1.Columns.Count-1)
                FClass.Data_List(listView1, 1);
        }

        private void button_Type_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cMSStyle.Show(button_Type, new Point(e.X, e.Y));
            }
        }

        private void TSMClarity_Click(object sender, EventArgs e)
        {
            Frm_Appear frmAppear = new Frm_Appear();
            if (frmAppear.ShowDialog() == DialogResult.OK)
            {
                this.Tag = 1;
                panel_Sele.Visible = true;
                if (frmAppear.Tag.ToString() == "1")
                    checkBox_Page.Text = "页  " + ModuleClass.FrmClass.C1;
                else
                    checkBox_Page.Text = "页";
                button_Build_Click(sender, e);
                FClass.SaveDataGridView(dataGridView1);

                listView1.Items.Clear();//清空所有项的集合
                listView1.Columns.Clear();//清空所有列的集合
                listView1.View = View.Details;//显示列名称
                listView1.Columns.Add("", listView1.Parent.Width - 3, HorizontalAlignment.Center);//设置列标头的名称及大小
            }
        }

        private void TSMStat_Click(object sender, EventArgs e)
        {
            panel_Sele.Visible = false;
            Frm_Statistics frmStatistics = new Frm_Statistics();
            if (frmStatistics.ShowDialog() == DialogResult.OK)
            {
                this.Tag = 2;
                button_Build_Click(sender, e);
            }

        }

        private void button_Property_Click(object sender, EventArgs e)
        {
            if (panel_Property.Visible)
                panel_Property.Visible = false;
            else
                panel_Property.Visible = true;
        }

        private void button_Font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TitFont = fontDialog1.Font;
                FClass.GetChartProperty(chartPanel1, fontDialog1.Font, Convert.ToInt32(((Button)sender).Tag.ToString()));
            }
            fontDialog1.Dispose();
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                FClass.GetChartProperty(chartPanel1, colorDialog1.Color, Convert.ToInt32(((Button)sender).Tag.ToString()));
            }
            fontDialog1.Dispose();
        }

        private void comboBox_Label_TextChanged(object sender, EventArgs e)
        {
            FClass.GetChartProperty(chartPanel1, ((ComboBox)sender).SelectedIndex, Convert.ToInt32(((ComboBox)sender).Tag.ToString()));
        }

        private void button_Title_Click(object sender, EventArgs e)
        {
            FClass.GetChartProperty(chartPanel1, textBox_Title.Text, Convert.ToInt32(((Button)sender).Tag.ToString()));
        }

        private void tabControl_Stat_Click(object sender, EventArgs e)
        {
            if (tabControl_Stat.SelectedTab.Name == "tabPage_Data")
            {
                button_Property.Visible = false;
                button_Print.Visible = true;
                button_Find.Visible = true;
            }
            if (tabControl_Stat.SelectedTab.Name == "tabPage_Chart")
            {
                button_Property.Visible = true;
                button_Print.Visible = false;
                button_Find.Visible = false;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Stat_FormClosed(object sender, FormClosedEventArgs e)
        {
            DClass.getDataSet("DROP PROCEDURE Pro_DynamicRendering","");
        }

        private void button_Build_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            switch (Convert.ToInt32(this.Tag.ToString()))
            {
                case 1:
                    {
                        FClass.filterField(listView1);
                        ProDSet = DClass.getDataSet("Exec Pro_DynamicRendering " + "'" + ModuleClass.DataClass.OldSQL + "','" + ModuleClass.FrmClass.C1 + "','" + ModuleClass.FrmClass.V1 + "','" + ModuleClass.FrmClass.C2 + "','" + ModuleClass.FrmClass.V2 + "','" + ModuleClass.FrmClass.C3 + "','" + ModuleClass.FrmClass.V3 + "','" + ModuleClass.FrmClass.C4 + "','" + ModuleClass.FrmClass.C5 + "'", "");
                        ChartCreate();
                        break;
                    }
                case 2:
                    {
                        ProDSet = DClass.getDataSet(ModuleClass.FrmClass.C1, "");
                        ChartCreate();
                        break;
                    }
            }
            dataGridView1.DataSource = ProDSet.Tables[0];
        }

        private void checkBox_Page_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox_Page.Checked)
            {
                FClass.Data_List(listView1, ModuleClass.FrmClass.C1, 2);
            }
            else
            {
                listView1.Items.Clear();//清空所有项的集合
                listView1.Columns.Clear();//清空所有列的集合
                listView1.View = View.Details;//显示列名称
                listView1.Columns.Add("", listView1.Parent.Width - 3, HorizontalAlignment.Center);//设置列标头的名称及大小
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

    }
}