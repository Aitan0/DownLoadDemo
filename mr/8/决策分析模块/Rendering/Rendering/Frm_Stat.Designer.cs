namespace Rendering
{
    partial class Frm_Stat
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Build = new System.Windows.Forms.Panel();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Find = new System.Windows.Forms.Button();
            this.button_Property = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Type = new System.Windows.Forms.Button();
            this.panel_Cont = new System.Windows.Forms.Panel();
            this.tabControl_Stat = new System.Windows.Forms.TabControl();
            this.tabPage_Data = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_Sele = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel_Page = new System.Windows.Forms.Panel();
            this.checkBox_Page = new System.Windows.Forms.CheckBox();
            this.button_Build = new System.Windows.Forms.Button();
            this.tabPage_Chart = new System.Windows.Forms.TabPage();
            this.chartPanel1 = new ChartComponent.ChartPanel();
            this.panel_Property = new System.Windows.Forms.Panel();
            this.button_Title = new System.Windows.Forms.Button();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_ChartStyle = new System.Windows.Forms.Label();
            this.ComboBox_ChartStyle = new System.Windows.Forms.ComboBox();
            this.button_Color = new System.Windows.Forms.Button();
            this.button_Font = new System.Windows.Forms.Button();
            this.comboBox_Lattice = new System.Windows.Forms.ComboBox();
            this.comboBox_Whereat = new System.Windows.Forms.ComboBox();
            this.comboBox_Tagboard = new System.Windows.Forms.ComboBox();
            this.comboBox_Label = new System.Windows.Forms.ComboBox();
            this.label_Lattice = new System.Windows.Forms.Label();
            this.label_Whereat = new System.Windows.Forms.Label();
            this.label_Tagboard = new System.Windows.Forms.Label();
            this.label_Label = new System.Windows.Forms.Label();
            this.label_TitleColor = new System.Windows.Forms.Label();
            this.label_TitleFont = new System.Windows.Forms.Label();
            this.label_Line = new System.Windows.Forms.Label();
            this.cMSStyle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMClarity = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMStat = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel_Build.SuspendLayout();
            this.panel_Cont.SuspendLayout();
            this.tabControl_Stat.SuspendLayout();
            this.tabPage_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Sele.SuspendLayout();
            this.panel_Page.SuspendLayout();
            this.tabPage_Chart.SuspendLayout();
            this.panel_Property.SuspendLayout();
            this.cMSStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Build
            // 
            this.panel_Build.Controls.Add(this.button_Print);
            this.panel_Build.Controls.Add(this.button_Find);
            this.panel_Build.Controls.Add(this.button_Property);
            this.panel_Build.Controls.Add(this.button_Close);
            this.panel_Build.Controls.Add(this.button_Type);
            this.panel_Build.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Build.Location = new System.Drawing.Point(0, 312);
            this.panel_Build.Name = "panel_Build";
            this.panel_Build.Size = new System.Drawing.Size(620, 39);
            this.panel_Build.TabIndex = 1;
            // 
            // button_Print
            // 
            this.button_Print.Location = new System.Drawing.Point(199, 9);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(75, 23);
            this.button_Print.TabIndex = 5;
            this.button_Print.Text = "打印";
            this.button_Print.UseVisualStyleBackColor = true;
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(118, 9);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(75, 23);
            this.button_Find.TabIndex = 4;
            this.button_Find.Text = "查询";
            this.button_Find.UseVisualStyleBackColor = true;
            // 
            // button_Property
            // 
            this.button_Property.Location = new System.Drawing.Point(37, 9);
            this.button_Property.Name = "button_Property";
            this.button_Property.Size = new System.Drawing.Size(75, 23);
            this.button_Property.TabIndex = 3;
            this.button_Property.Text = "图表属性";
            this.button_Property.UseVisualStyleBackColor = true;
            this.button_Property.Visible = false;
            this.button_Property.Click += new System.EventHandler(this.button_Property_Click);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.Location = new System.Drawing.Point(524, 9);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "退出";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Type
            // 
            this.button_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Type.Location = new System.Drawing.Point(413, 9);
            this.button_Type.Name = "button_Type";
            this.button_Type.Size = new System.Drawing.Size(75, 23);
            this.button_Type.TabIndex = 0;
            this.button_Type.Text = "统计类型";
            this.button_Type.UseVisualStyleBackColor = true;
            this.button_Type.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Type_MouseUp);
            // 
            // panel_Cont
            // 
            this.panel_Cont.Controls.Add(this.tabControl_Stat);
            this.panel_Cont.Controls.Add(this.label_Line);
            this.panel_Cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Cont.Location = new System.Drawing.Point(0, 0);
            this.panel_Cont.Name = "panel_Cont";
            this.panel_Cont.Size = new System.Drawing.Size(620, 312);
            this.panel_Cont.TabIndex = 2;
            // 
            // tabControl_Stat
            // 
            this.tabControl_Stat.Controls.Add(this.tabPage_Data);
            this.tabControl_Stat.Controls.Add(this.tabPage_Chart);
            this.tabControl_Stat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Stat.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Stat.Name = "tabControl_Stat";
            this.tabControl_Stat.SelectedIndex = 0;
            this.tabControl_Stat.Size = new System.Drawing.Size(620, 310);
            this.tabControl_Stat.TabIndex = 1;
            this.tabControl_Stat.Click += new System.EventHandler(this.tabControl_Stat_Click);
            // 
            // tabPage_Data
            // 
            this.tabPage_Data.Controls.Add(this.dataGridView1);
            this.tabPage_Data.Controls.Add(this.panel_Sele);
            this.tabPage_Data.Location = new System.Drawing.Point(4, 21);
            this.tabPage_Data.Name = "tabPage_Data";
            this.tabPage_Data.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Data.Size = new System.Drawing.Size(612, 285);
            this.tabPage_Data.TabIndex = 0;
            this.tabPage_Data.Text = "数据表";
            this.tabPage_Data.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(472, 279);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // panel_Sele
            // 
            this.panel_Sele.Controls.Add(this.listView1);
            this.panel_Sele.Controls.Add(this.panel_Page);
            this.panel_Sele.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Sele.Location = new System.Drawing.Point(475, 3);
            this.panel_Sele.Name = "panel_Sele";
            this.panel_Sele.Size = new System.Drawing.Size(134, 279);
            this.panel_Sele.TabIndex = 0;
            this.panel_Sele.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(134, 225);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel_Page
            // 
            this.panel_Page.Controls.Add(this.checkBox_Page);
            this.panel_Page.Controls.Add(this.button_Build);
            this.panel_Page.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Page.Location = new System.Drawing.Point(0, 225);
            this.panel_Page.Name = "panel_Page";
            this.panel_Page.Size = new System.Drawing.Size(134, 54);
            this.panel_Page.TabIndex = 0;
            // 
            // checkBox_Page
            // 
            this.checkBox_Page.AutoSize = true;
            this.checkBox_Page.Location = new System.Drawing.Point(6, 6);
            this.checkBox_Page.Name = "checkBox_Page";
            this.checkBox_Page.Size = new System.Drawing.Size(36, 16);
            this.checkBox_Page.TabIndex = 1;
            this.checkBox_Page.Text = "页";
            this.checkBox_Page.UseVisualStyleBackColor = true;
            this.checkBox_Page.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkBox_Page_MouseUp);
            // 
            // button_Build
            // 
            this.button_Build.Location = new System.Drawing.Point(67, 28);
            this.button_Build.Name = "button_Build";
            this.button_Build.Size = new System.Drawing.Size(62, 23);
            this.button_Build.TabIndex = 0;
            this.button_Build.Text = "确定";
            this.button_Build.UseVisualStyleBackColor = true;
            this.button_Build.Click += new System.EventHandler(this.button_Build_Click);
            // 
            // tabPage_Chart
            // 
            this.tabPage_Chart.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Chart.Controls.Add(this.chartPanel1);
            this.tabPage_Chart.Controls.Add(this.panel_Property);
            this.tabPage_Chart.Location = new System.Drawing.Point(4, 21);
            this.tabPage_Chart.Name = "tabPage_Chart";
            this.tabPage_Chart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Chart.Size = new System.Drawing.Size(612, 285);
            this.tabPage_Chart.TabIndex = 1;
            this.tabPage_Chart.Text = "图表";
            // 
            // chartPanel1
            // 
            this.chartPanel1.AreaAngle = 0;
            this.chartPanel1.ChartColor = System.Drawing.Color.Red;
            this.chartPanel1.Chartmark = true;
            this.chartPanel1.ChartStyle = ChartComponent.ChartPanel.CharMode.Bar;
            this.chartPanel1.ChartWearColor = false;
            this.chartPanel1.DataSource = null;
            this.chartPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel1.FoulCalcar = 5;
            this.chartPanel1.FoulLineColor = System.Drawing.Color.Black;
            this.chartPanel1.LabelSay = false;
            this.chartPanel1.Location = new System.Drawing.Point(3, 3);
            this.chartPanel1.Name = "chartPanel1";
            this.chartPanel1.PageList = 7;
            this.chartPanel1.RowList = 10;
            this.chartPanel1.RowWeave = ChartComponent.ChartPanel.CharRowWeaveStyle.Stavked;
            this.chartPanel1.ShowData = true;
            this.chartPanel1.Size = new System.Drawing.Size(455, 279);
            this.chartPanel1.SumAxes = ChartComponent.ChartPanel.AxesStyle.Null;
            this.chartPanel1.SumXAxis = "";
            this.chartPanel1.SumYAxis = "";
            this.chartPanel1.TabIndex = 1;
            this.chartPanel1.TitleColor = System.Drawing.Color.Black;
            this.chartPanel1.TitleFont = new System.Drawing.Font("宋体", 9F);
            this.chartPanel1.TitleName = "Title";
            this.chartPanel1.TitleStyle = ChartComponent.ChartPanel.ChartTitleStyle.TopCenter;
            this.chartPanel1.XYColor = System.Drawing.Color.Black;
            this.chartPanel1.XYFont = new System.Drawing.Font("宋体", 9F);
            // 
            // panel_Property
            // 
            this.panel_Property.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Property.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Property.Controls.Add(this.button_Title);
            this.panel_Property.Controls.Add(this.textBox_Title);
            this.panel_Property.Controls.Add(this.label_Title);
            this.panel_Property.Controls.Add(this.label_ChartStyle);
            this.panel_Property.Controls.Add(this.ComboBox_ChartStyle);
            this.panel_Property.Controls.Add(this.button_Color);
            this.panel_Property.Controls.Add(this.button_Font);
            this.panel_Property.Controls.Add(this.comboBox_Lattice);
            this.panel_Property.Controls.Add(this.comboBox_Whereat);
            this.panel_Property.Controls.Add(this.comboBox_Tagboard);
            this.panel_Property.Controls.Add(this.comboBox_Label);
            this.panel_Property.Controls.Add(this.label_Lattice);
            this.panel_Property.Controls.Add(this.label_Whereat);
            this.panel_Property.Controls.Add(this.label_Tagboard);
            this.panel_Property.Controls.Add(this.label_Label);
            this.panel_Property.Controls.Add(this.label_TitleColor);
            this.panel_Property.Controls.Add(this.label_TitleFont);
            this.panel_Property.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Property.Location = new System.Drawing.Point(458, 3);
            this.panel_Property.Name = "panel_Property";
            this.panel_Property.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_Property.Size = new System.Drawing.Size(151, 279);
            this.panel_Property.TabIndex = 0;
            this.panel_Property.Visible = false;
            // 
            // button_Title
            // 
            this.button_Title.Location = new System.Drawing.Point(102, 52);
            this.button_Title.Name = "button_Title";
            this.button_Title.Size = new System.Drawing.Size(40, 20);
            this.button_Title.TabIndex = 16;
            this.button_Title.Tag = "0";
            this.button_Title.Text = "确定";
            this.button_Title.UseVisualStyleBackColor = true;
            this.button_Title.Click += new System.EventHandler(this.button_Title_Click);
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(10, 28);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(132, 21);
            this.textBox_Title.TabIndex = 15;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(8, 11);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(41, 12);
            this.label_Title.TabIndex = 14;
            this.label_Title.Text = "标题：";
            // 
            // label_ChartStyle
            // 
            this.label_ChartStyle.AutoSize = true;
            this.label_ChartStyle.Location = new System.Drawing.Point(6, 240);
            this.label_ChartStyle.Name = "label_ChartStyle";
            this.label_ChartStyle.Size = new System.Drawing.Size(65, 12);
            this.label_ChartStyle.TabIndex = 13;
            this.label_ChartStyle.Text = "图表类型：";
            // 
            // ComboBox_ChartStyle
            // 
            this.ComboBox_ChartStyle.FormattingEnabled = true;
            this.ComboBox_ChartStyle.Items.AddRange(new object[] {
            "条形图",
            "线形图",
            "面形图",
            "饼形图"});
            this.ComboBox_ChartStyle.Location = new System.Drawing.Point(74, 236);
            this.ComboBox_ChartStyle.Name = "ComboBox_ChartStyle";
            this.ComboBox_ChartStyle.Size = new System.Drawing.Size(68, 20);
            this.ComboBox_ChartStyle.TabIndex = 12;
            this.ComboBox_ChartStyle.Tag = "7";
            this.ComboBox_ChartStyle.TextChanged += new System.EventHandler(this.comboBox_Label_TextChanged);
            // 
            // button_Color
            // 
            this.button_Color.Location = new System.Drawing.Point(74, 104);
            this.button_Color.Name = "button_Color";
            this.button_Color.Size = new System.Drawing.Size(68, 23);
            this.button_Color.TabIndex = 11;
            this.button_Color.Tag = "2";
            this.button_Color.Text = "颜色";
            this.button_Color.UseVisualStyleBackColor = true;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // button_Font
            // 
            this.button_Font.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Font.Location = new System.Drawing.Point(74, 78);
            this.button_Font.Name = "button_Font";
            this.button_Font.Size = new System.Drawing.Size(68, 23);
            this.button_Font.TabIndex = 10;
            this.button_Font.Tag = "1";
            this.button_Font.Text = "字体";
            this.button_Font.UseVisualStyleBackColor = false;
            this.button_Font.Click += new System.EventHandler(this.button_Font_Click);
            // 
            // comboBox_Lattice
            // 
            this.comboBox_Lattice.FormattingEnabled = true;
            this.comboBox_Lattice.Items.AddRange(new object[] {
            "左右组合",
            "上下组合"});
            this.comboBox_Lattice.Location = new System.Drawing.Point(74, 209);
            this.comboBox_Lattice.Name = "comboBox_Lattice";
            this.comboBox_Lattice.Size = new System.Drawing.Size(68, 20);
            this.comboBox_Lattice.TabIndex = 9;
            this.comboBox_Lattice.Tag = "6";
            this.comboBox_Lattice.TextChanged += new System.EventHandler(this.comboBox_Label_TextChanged);
            // 
            // comboBox_Whereat
            // 
            this.comboBox_Whereat.FormattingEnabled = true;
            this.comboBox_Whereat.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBox_Whereat.Location = new System.Drawing.Point(74, 183);
            this.comboBox_Whereat.Name = "comboBox_Whereat";
            this.comboBox_Whereat.Size = new System.Drawing.Size(68, 20);
            this.comboBox_Whereat.TabIndex = 8;
            this.comboBox_Whereat.Tag = "5";
            this.comboBox_Whereat.TextChanged += new System.EventHandler(this.comboBox_Label_TextChanged);
            // 
            // comboBox_Tagboard
            // 
            this.comboBox_Tagboard.FormattingEnabled = true;
            this.comboBox_Tagboard.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBox_Tagboard.Location = new System.Drawing.Point(74, 157);
            this.comboBox_Tagboard.Name = "comboBox_Tagboard";
            this.comboBox_Tagboard.Size = new System.Drawing.Size(68, 20);
            this.comboBox_Tagboard.TabIndex = 7;
            this.comboBox_Tagboard.Tag = "4";
            this.comboBox_Tagboard.TextChanged += new System.EventHandler(this.comboBox_Label_TextChanged);
            // 
            // comboBox_Label
            // 
            this.comboBox_Label.FormattingEnabled = true;
            this.comboBox_Label.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBox_Label.Location = new System.Drawing.Point(74, 131);
            this.comboBox_Label.Name = "comboBox_Label";
            this.comboBox_Label.Size = new System.Drawing.Size(68, 20);
            this.comboBox_Label.TabIndex = 6;
            this.comboBox_Label.Tag = "3";
            this.comboBox_Label.TextChanged += new System.EventHandler(this.comboBox_Label_TextChanged);
            // 
            // label_Lattice
            // 
            this.label_Lattice.AutoSize = true;
            this.label_Lattice.Location = new System.Drawing.Point(6, 213);
            this.label_Lattice.Name = "label_Lattice";
            this.label_Lattice.Size = new System.Drawing.Size(65, 12);
            this.label_Lattice.TabIndex = 5;
            this.label_Lattice.Text = "组合样式：";
            // 
            // label_Whereat
            // 
            this.label_Whereat.AutoSize = true;
            this.label_Whereat.Location = new System.Drawing.Point(8, 187);
            this.label_Whereat.Name = "label_Whereat";
            this.label_Whereat.Size = new System.Drawing.Size(53, 12);
            this.label_Whereat.TabIndex = 4;
            this.label_Whereat.Text = "随机色：";
            // 
            // label_Tagboard
            // 
            this.label_Tagboard.AutoSize = true;
            this.label_Tagboard.Location = new System.Drawing.Point(8, 161);
            this.label_Tagboard.Name = "label_Tagboard";
            this.label_Tagboard.Size = new System.Drawing.Size(53, 12);
            this.label_Tagboard.TabIndex = 3;
            this.label_Tagboard.Text = "标签框：";
            // 
            // label_Label
            // 
            this.label_Label.AutoSize = true;
            this.label_Label.Location = new System.Drawing.Point(8, 135);
            this.label_Label.Name = "label_Label";
            this.label_Label.Size = new System.Drawing.Size(41, 12);
            this.label_Label.TabIndex = 2;
            this.label_Label.Text = "标注：";
            // 
            // label_TitleColor
            // 
            this.label_TitleColor.AutoSize = true;
            this.label_TitleColor.Location = new System.Drawing.Point(8, 109);
            this.label_TitleColor.Name = "label_TitleColor";
            this.label_TitleColor.Size = new System.Drawing.Size(65, 12);
            this.label_TitleColor.TabIndex = 1;
            this.label_TitleColor.Text = "标题颜色：";
            // 
            // label_TitleFont
            // 
            this.label_TitleFont.AutoSize = true;
            this.label_TitleFont.Location = new System.Drawing.Point(8, 83);
            this.label_TitleFont.Name = "label_TitleFont";
            this.label_TitleFont.Size = new System.Drawing.Size(65, 12);
            this.label_TitleFont.TabIndex = 0;
            this.label_TitleFont.Text = "标题字体：";
            // 
            // label_Line
            // 
            this.label_Line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Line.Location = new System.Drawing.Point(0, 310);
            this.label_Line.Name = "label_Line";
            this.label_Line.Size = new System.Drawing.Size(620, 2);
            this.label_Line.TabIndex = 0;
            // 
            // cMSStyle
            // 
            this.cMSStyle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMClarity,
            this.TSMStat});
            this.cMSStyle.Name = "cMSStyle";
            this.cMSStyle.Size = new System.Drawing.Size(107, 48);
            // 
            // TSMClarity
            // 
            this.TSMClarity.Name = "TSMClarity";
            this.TSMClarity.Size = new System.Drawing.Size(106, 22);
            this.TSMClarity.Text = "透视表";
            this.TSMClarity.Click += new System.EventHandler(this.TSMClarity_Click);
            // 
            // TSMStat
            // 
            this.TSMStat.Name = "TSMStat";
            this.TSMStat.Size = new System.Drawing.Size(106, 22);
            this.TSMStat.Text = "统计表";
            this.TSMStat.Click += new System.EventHandler(this.TSMStat_Click);
            // 
            // Frm_Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 351);
            this.Controls.Add(this.panel_Cont);
            this.Controls.Add(this.panel_Build);
            this.Name = "Frm_Stat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0";
            this.Text = "决策分析";
            this.Shown += new System.EventHandler(this.Frm_Stat_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Stat_FormClosed);
            this.panel_Build.ResumeLayout(false);
            this.panel_Cont.ResumeLayout(false);
            this.tabControl_Stat.ResumeLayout(false);
            this.tabPage_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Sele.ResumeLayout(false);
            this.panel_Page.ResumeLayout(false);
            this.panel_Page.PerformLayout();
            this.tabPage_Chart.ResumeLayout(false);
            this.panel_Property.ResumeLayout(false);
            this.panel_Property.PerformLayout();
            this.cMSStyle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Build;
        private System.Windows.Forms.Panel panel_Cont;
        private System.Windows.Forms.Label label_Line;
        private System.Windows.Forms.TabControl tabControl_Stat;
        private System.Windows.Forms.TabPage tabPage_Data;
        private System.Windows.Forms.TabPage tabPage_Chart;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Type;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_Sele;
        private System.Windows.Forms.Panel panel_Page;
        private System.Windows.Forms.Button button_Build;
        private System.Windows.Forms.CheckBox checkBox_Page;
        private System.Windows.Forms.ContextMenuStrip cMSStyle;
        private System.Windows.Forms.ToolStripMenuItem TSMClarity;
        private System.Windows.Forms.ToolStripMenuItem TSMStat;
        private System.Windows.Forms.Panel panel_Property;
        private System.Windows.Forms.Label label_Lattice;
        private System.Windows.Forms.Label label_Whereat;
        private System.Windows.Forms.Label label_Tagboard;
        private System.Windows.Forms.Label label_Label;
        private System.Windows.Forms.Label label_TitleColor;
        private System.Windows.Forms.Label label_TitleFont;
        private System.Windows.Forms.ComboBox comboBox_Lattice;
        private System.Windows.Forms.ComboBox comboBox_Whereat;
        private System.Windows.Forms.ComboBox comboBox_Tagboard;
        private System.Windows.Forms.ComboBox comboBox_Label;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button_Color;
        private System.Windows.Forms.Button button_Font;
        private System.Windows.Forms.Label label_ChartStyle;
        private System.Windows.Forms.ComboBox ComboBox_ChartStyle;
        private System.Windows.Forms.Button button_Property;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Button button_Title;
        private System.Windows.Forms.ListView listView1;
        private ChartComponent.ChartPanel chartPanel1;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_Find;
    }
}