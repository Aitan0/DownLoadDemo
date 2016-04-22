using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ChartComponent
{
    public partial class ChartPanel : UserControl
    {
        #region 添加属性
        private DataSet PDataSource = null;
        [Browsable(true), Category("图表属性设置"), Description("连接数据表")]   //在“属性”窗口中显示DataSource属性
        public DataSet DataSource
        {
            get { return PDataSource; }
            set 
            { 
                PDataSource = value;
                ChartFirst();
                Invalidate();
            }
        }

        public enum AxesStyle
        {
            Null = 0,//无
            X = 1,//对X轴进行汇总
            Y = 2,//对Y轴进行汇总
            XY = 3,//对XY轴进行汇总            
        }

        private AxesStyle PSumAxes =  AxesStyle.Null;
        [Browsable(true), Category("图表属性设置"), Description("设置进行汇总的轴")] //在“属性”窗口中显示SumAxes属性
        public AxesStyle SumAxes
        {
            get { return PSumAxes; }
            set
            {
                PSumAxes = value;
                if (PSumAxes != AxesStyle.Null)
                {
                    this.SumYAxis = "";
                }
            }
        }

        private string PSumXAxis = "";
        [Browsable(true), Category("图表属性设置"), Description("设置统计字段")]   //在“属性”窗口中显示SumXAxis属性
        public string SumXAxis
        {
            get { return PSumXAxis; }
            set 
            { 
                PSumXAxis = value;
            }
        }

        private string PSumYAxis = "";
        [Browsable(true), Category("图表属性设置"), Description("设置统计的数据字段")]   //在“属性”窗口中显示SumYAxis属性
        public string SumYAxis
        {
            get { return PSumYAxis; }
            set 
            { 
                PSumYAxis = value;
                if (PSumYAxis != "")
                    this.SumAxes = AxesStyle.Null;
            }
        }

        public enum CharMode
        {
            Bar = 0,//条形
            Mark = 1,//面形
            Line = 2,//线形
            Area = 3,//饼形
            none = 4,//空
        }

        public enum ChartTitleStyle
        {
            TopLeft = 0,//置顶居左
            TopCenter = 1,//置顶居中
            TopRight = 2,//置顶居右
            BottomLeft=3,//置底居左
            BottomCenter = 4,//置底居中
            BottomRight = 5,//置底居右
        }

        private CharMode PChartStyle = CharMode.Bar;
        [Browsable(true), Category("图表属性设置"), Description("图表的类型")]   //在“属性”窗口中显示ChartStyle属性

        public CharMode ChartStyle
        {
            get
            {
                return PChartStyle;
            }
            set
            {
                PChartStyle = value;
                if (this.ChartStyle == CharMode.Bar || this.ChartStyle == CharMode.Mark)
                {
                    if (this.RowWeave == CharRowWeaveStyle.Stavked)
                    {
                        if (this.RowList == 1)
                            RowSideMax();
                        else
                            RowStackedSum();
                    }

                    if (this.RowWeave == CharRowWeaveStyle.Side)
                        RowSideMax();
                }
                if (this.ChartStyle== CharMode.Line)
                    RowSideMax();
                if (this.ChartStyle == CharMode.Area)
                {
                    AreaPercent();
                }
                Invalidate();
            }
        }

        private ChartTitleStyle PTitleStyle = ChartTitleStyle.TopCenter;
        [Browsable(true), Category("图表属性设置"), Description("图表的标题位置")]   //在“属性”窗口中显示TitleStyle属性

        public ChartTitleStyle TitleStyle
        {
            get { return PTitleStyle; }
            set
            {
                PTitleStyle = value;
                Invalidate();
            }
        }

        private Color PTitleColor = Color.Black;
        [Browsable(true), Category("图表属性设置"), Description("图表的标题颜色")]   //在“属性”窗口中显示TitleColor属性

        public Color TitleColor
        {
            get { return PTitleColor; }
            set
            {
                PTitleColor = value;
                Invalidate();
            }
        }

        private Color PChartColor = Color.Red;
        [Browsable(true), Category("图表属性设置"), Description("图表的图形颜色")]   //在“属性”窗口中显示ChartColor属性

        public Color ChartColor
        {
            get { return PChartColor; }
            set 
            { 
                PChartColor = value;
                Invalidate();
            }
        }

        private bool PChartWearColor = false;
        [Browsable(true), Category("图表属性设置"), Description("图表的图形多个颜色")]   //在“属性”窗口中显示ChartWearColor属性

        public bool ChartWearColor
        {
            get { return PChartWearColor; }
            set
            {
                PChartWearColor = value;
                if (this.RowList == 1)
                    if (this.ChartStyle == CharMode.Bar)
                        Invalidate();
            }
        }

        private bool PChartmark = true;
        [Browsable(true), Category("图表属性设置"), Description("是否显示数据标签")]   //在“属性”窗口中显示Chartmark属性

        public bool Chartmark 
        {
            get { return PChartmark; }
            set
            {
                PChartmark = value;
                Invalidate();
            }
        }

        private string PTitleName = "Title";
        [Browsable(true), Category("图表属性设置"), Description("图表的标题")]   //在“属性”窗口中显示TitleName属性

        public string TitleName
        {
            get { return PTitleName; }
            set
            {
                PTitleName = value;
                Invalidate();
            }
        }

        private Font PTitleFont = new Font("宋体", 9);
        [Browsable(true), Category("图表属性设置"), Description("图表的标题文字样式")]   //在“属性”窗口中显示TitleFont属性

        public Font TitleFont
        {
            get { return PTitleFont; }
            set
            {
                PTitleFont = value;
                Invalidate();
            }
        }

        private int PFoulCalcar = 5;
        [Browsable(true), Category("图表属性设置"), Description("图表的边距")]   //在“属性”窗口中显示FoulCalcar属性
        public int FoulCalcar
        {
            get { return PFoulCalcar; }
            set
            {
                PFoulCalcar = value;
                if (PFoulCalcar < 0)
                    PFoulCalcar = 0;
                Invalidate();
            }
        }

        private Color PFoulLineColor = Color.Black;
        [Browsable(true), Category("图表属性设置"), Description("图表的边线颜色")]   //在“属性”窗口中显示FoulLineColor属性

        public Color FoulLineColor
        {
            get { return PFoulLineColor; }
            set 
            { 
                PFoulLineColor = value;
                Invalidate();
            }
        }

        private Font PXYFont = new Font("宋体", 9);
        [Browsable(true), Category("图表属性设置"), Description("图表X、Y轴的文字样式")]   //在“属性”窗口中显示XYFont属性

        public Font XYFont
        {
            get { return PXYFont; }
            set
            {
                PXYFont = value;
                Invalidate();
            }
        }

        private Color PXYColor = Color.Black;
        [Browsable(true), Category("图表属性设置"), Description("图表中XY轴标识文字的颜色")]   //在“属性”窗口中显示XYColor属性

        public Color XYColor
        {
            get { return PXYColor; }
            set
            {
                PXYColor = value;
                Invalidate();
            }
        }

        private int PPageList = 10;
        [Browsable(true), Category("图表属性设置"), Description("设置图表中每页的列数")]   //在“属性”窗口中显示PageList属性

        public int PageList
        {
            get { return PPageList; }
            set
            {
                PPageList = value;
                if (PPageList < 1)
                    PPageList = 1;
                if (this.DataSource == null)
                    ChartFirst();
                if (this.ChartStyle == CharMode.Bar || this.ChartStyle == CharMode.Mark)
                {
                    if (this.RowWeave == CharRowWeaveStyle.Stavked)
                    {
                        if (this.RowList == 1)
                            RowSideMax();
                        else
                            RowStackedSum();
                    }
                    if (this.RowWeave == CharRowWeaveStyle.Side)
                        RowSideMax();
                }
                if (this.ChartStyle == CharMode.Area)
                {
                    AreaPercent();
                }
                Invalidate();
            }
        }

        private int PRowList = 1;
        [Browsable(true), Category("图表属性设置"), Description("设置每列中数据个数")]   //在“属性”窗口中显示RowList属性

        public int RowList
        {
            get { return PRowList; }
            set
            {
                PRowList = value;
                if (PRowList < 1)
                    PRowList = 1;
                if (this.DataSource == null)
                    ChartFirst();
                if (this.ChartStyle == CharMode.Bar || this.ChartStyle == CharMode.Mark)
                {
                    if (this.RowWeave == CharRowWeaveStyle.Stavked)
                    {
                        if (this.RowList == 1)
                            RowSideMax();
                        else
                            RowStackedSum();
                    }
                    if (this.RowWeave == CharRowWeaveStyle.Side)
                        RowSideMax();
                }
                if (this.ChartStyle == CharMode.Area)
                {
                    AreaPercent();
                }
                Invalidate();
            }
        }

        private bool PLabelSay = false;
        [Browsable(true), Category("图表属性设置"), Description("设置图表的标签说明")]   //在“属性”窗口中显示LabelSay属性

        public bool LabelSay
        {
            get { return PLabelSay; }
            set
            {
                PLabelSay = value;
                if (this.ShowData == false)
                    PLabelSay = false;
                Invalidate();
            }
        }

        public enum CharRowWeaveStyle
        {
            Side= 0,//侧面显示
            Stavked = 1,//单列组合显示
        }

        private CharRowWeaveStyle PRowWeave = CharRowWeaveStyle.Side;
        [Browsable(true), Category("图表属性设置"), Description("多列图表的组合样式")]   //在“属性”窗口中显示RowWeave属性

        public CharRowWeaveStyle RowWeave
        {
            get { return PRowWeave; }
            set
            {
                PRowWeave = value;
                if (this.RowList > 1)
                {
                    if (this.ChartStyle == CharMode.Bar || this.ChartStyle == CharMode.Mark)
                    {
                        if (PRowWeave == CharRowWeaveStyle.Stavked)
                        {
                            if (this.RowList == 1)
                                RowSideMax();
                            else
                                RowStackedSum();
                        }
                        if (PRowWeave == CharRowWeaveStyle.Side)
                            RowSideMax();
                        
                        Invalidate();
                    }
                }
            }
        }

        private bool PShowData = true;
        [Browsable(true), Category("图表属性设置"), Description("是否显示图表中的数据")]   //在“属性”窗口中显示ShowData属性

        public bool ShowData
        {
            get { return PShowData; }
            set
            {
                PShowData = value;
                if (PShowData == false)
                    this.ChartStyle = CharMode.none;
                else
                    this.ChartStyle = CharMode.Bar;
                ChartFirst();
                Invalidate();
            }
        }

        private int PAreaAngle = 0;
        [Browsable(true), Category("图表属性设置"), Description("设置饼形图的旋转角度")]   //在“属性”窗口中显示AreaAngle属性

        public int AreaAngle
        {
            get { return PAreaAngle; }
            set
            {
                PAreaAngle = value;
                if (PAreaAngle < 0)
                    PAreaAngle = 360;
                if (PAreaAngle > 360)
                    PAreaAngle = 0;
                Invalidate();
            }
        }
        #endregion

        #region 公共变量
        public static Color[] WearColor = new Color[] { Color.Red,Color.Gold,Color.Chartreuse,Color.Teal,Color.RoyalBlue,Color.Fuchsia,Color.Firebrick,
            Color.Goldenrod,Color.ForestGreen,Color.Aqua,Color.Blue,Color.PaleVioletRed,Color.Salmon,Color.Yellow,Color.LimeGreen,Color.LightBlue,Color.LightSteelBlue,Color.MediumPurple};
        public static int Initialize = 0;
        public static float[,] ZData;//记录数据的值
        public static float YMax = 0;//数值的最大值
        public static float LoadS = 0;
        public static float YHeightM = 0;
        public static int[] XData;//记录X轴的标识数
        public static string[] XText;//记录X轴的标识数
        public static string[] ZText;//记录X轴的标识数
        public static float[] SzData;//获取每列的和
        public static float ASum;//记录饼形的总和
        public static float XSize = 0;//X轴的大小
        public static float YSize = 0;//Y轴的大小
        public static float TemXSize = 0;//X轴的临时大小
        public static float XLeft = 0;//X轴的左端点
        public static float XRight = 0;//X轴的右端点
        public static float YUp = 0;//Y轴的上端点
        public static float YDown = 0;//Y轴的下端点
        public static float YUnit = 0;//纵向的单元格宽度
        public static float XUnit = 0;//横向的单元格宽度
        public static float temXLeft = 0;//X轴的左端点初始化
        public static Pen mypen = new Pen(Color.Black, 1);//设置线的颜色及粗细
        public static Pen penvoid = new Pen(Color.DarkGray, 1);//设置线的颜色及粗细
        public static SolidBrush mybrush = new SolidBrush(Color.Red);
        public static Brush BXYColor = new SolidBrush(Color.Black);
        public static float TitHeight = 0;//记录标题的高度
        public static float ChartStyle_sign = 0;//图表样式的标识
        public static float RowL = 0;//记录每Y列中的个数
        public static float PageL = 0;//记录X轴Y列的个数
        public static int Xcou = 0;
        #endregion

        public ChartPanel()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ChartFirst();
        }

        #region 数据的初始化
        /// <summary>
        /// 数据的初始化
        /// </summary>
        public void ChartFirst()
        {
            Random rand = new Random();//随机获取100以内的数据
            RowL = this.RowList;//记录每列中的记录个数
            PageL = this.PageList;//记录Y轴的列数

            if (this.DataSource == null || this.ShowData == false)
            {
                if (this.ShowData == false)
                {
                    RowL = 1;//记录每列中的记录个数
                    PageL = 10;//记录Y轴的列数
                }
                ZData = new float[(int)PageL, (int)RowL];//记录随机数据一维数组
                XData = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };//记录随机数据一维数组
                XText = new string[(int)PageL];
                ZText = new string[(int)RowL];//记录X轴的标识数
                for (int i = 0; i < XText.Length; i++)
                {
                    XText[i] = "X_" + i.ToString();
                }
                if (this.RowList > 1)
                {
                    for (int i = 0; i < ZText.Length; i++)
                    {
                        ZText[i] = "Z_" + i.ToString();
                    }
                }
                for (int j = 0; j < XText.Length; j++)
                {
                    for (int i = 0; i < ZText.Length; i++)
                    {
                        ZData[j, i] = rand.Next(1, 10000);
                        if (YMax < ZData[j, i])
                            YMax = ZData[j, i];
                    }
                }
                double nY = YMax + YMax * 0.3;
                if (nY == 0)
                {
                    this.ChartStyle = CharMode.none;
                    YMax = 10;
                    YHeightM = 100;
                    Invalidate();
                    return;
                }
                if (nY < 11)//设置X轴的刻度
                {
                    YHeightM = (float)Math.Ceiling(nY);//Y轴的最大高度
                    Xcou = (int)(Math.Ceiling(nY)) + 1;
                    XData = new int[Xcou];//记录随机数据一维数组
                    for (int i = 0; i < XData.Length; i++)
                        XData[i] = 0;
                }
                else
                {
                    YMax = (int)(Math.Ceiling(nY / 10));
                    YHeightM = YMax * 10;//Y轴的最大高度
                }
            }
            else
            {
                int rowC = 0;
                int ColumnC = 0;
                
                if (this.SumAxes != AxesStyle.Null && this.SumXAxis != "")
                {
                    rowC = DataSource.Tables[0].Rows.Count;
                    ColumnC = DataSource.Tables[0].Columns.Count;
                    if (this.SumAxes == AxesStyle.X)
                        ColumnC = ColumnC - 1;
                    if (this.SumAxes == AxesStyle.Y)
                        rowC = rowC - 1;
                    if (this.SumAxes == AxesStyle.XY)
                    {
                        rowC = rowC - 1;
                        ColumnC = ColumnC - 1;

                    }

                    ZData = new float[rowC, ColumnC];//记录随机数据一维数组
                    XData = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };//记录随机数据一维数组
                    XText = new string[rowC];
                    ZText = new string[ColumnC-1];//记录X轴的标识数
                    int temCloumn=0;
                    for (int i = 0; i < ColumnC; i++)
                    {
                        if (DataSource.Tables[0].Columns[i].Caption.Trim() == this.SumXAxis.Trim())
                        {
                            for (int j = 0; j < rowC; j++)
                            {
                                XText[j] = DataSource.Tables[0].Rows[j][i].ToString();
                            }
                            temCloumn = temCloumn + 1;
                        }
                        else
                        {
                            ZText[i-temCloumn] = DataSource.Tables[0].Columns[i].Caption.Trim();
                            for (int j = 0; j < rowC; j++)
                            {
                                ZData[j,i-temCloumn ] = Convert.ToSingle(DataSource.Tables[0].Rows[j][i]);
                            }
                        }
                    }
                    this.PageList = XText.Length;
                    this.RowList = ZText.Length;
                    PageL = this.PageList;
                    RowL = this.RowList;
                    if (this.RowWeave == CharRowWeaveStyle.Side)
                        RowStackedSum();
                    else
                        RowSideMax();
                    //RowSideMax();
                }
                if (this.SumXAxis != "" && this.SumYAxis != "")
                {
                    rowC = DataSource.Tables[0].Rows.Count;
                    ColumnC = DataSource.Tables[0].Columns.Count;
                    ZData = new float[rowC, ColumnC];//记录随机数据一维数组
                    XData = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };//记录随机数据一维数组
                    XText = new string[rowC];
                    ZText = new string[ColumnC-1];//记录X轴的标识数
                    int temCloumn = 0;
                    for (int i = 0; i < ColumnC; i++)
                    {
                        if (DataSource.Tables[0].Columns[i].Caption.Trim() == this.SumXAxis.Trim())
                        {
                            for (int j = 0; j < rowC; j++)
                            {
                                XText[j] = DataSource.Tables[0].Rows[j][i].ToString();
                            }
                            temCloumn = temCloumn + 1;
                        }
                        else
                        {
                            ZText[i - temCloumn] = DataSource.Tables[0].Columns[i].Caption.Trim();
                            for (int j = 0; j < rowC; j++)
                            {
                                ZData[j, i-temCloumn] = Convert.ToSingle(DataSource.Tables[0].Rows[j][i]);
                            }
                        }
                    }
                    this.PageList = XText.Length;
                    this.RowList = ZText.Length;
                    PageL = this.PageList;
                    RowL = this.RowList;
                    if (this.RowWeave == CharRowWeaveStyle.Side)
                        RowStackedSum();
                    else
                        RowSideMax();
                }

            }

        }
        #endregion

        #region 获取饼形图的值
        /// <summary>
        /// 获取饼形图的值
        /// </summary>
        public void AreaPercent()
        {
            RowStackedSum();
            ASum = 0;
            for (int i = 0; i < SzData.Length; i++)
                ASum = ASum + SzData[i];
            if (ASum == 0)
            {
                this.ChartStyle = CharMode.none;
                YMax = 10;
                YHeightM = 100;
                Invalidate();
                return;
            }
        }

        #endregion

        #region 单列多数据最大值
        /// <summary>
        /// 单列多数据最大值
        /// </summary>
        public void RowSideMax()
        {
            YMax = 0;
            SzData = new float[XText.Length];
            for (int j = 0; j < XText.Length; j++)
            {
                for (int i = 0; i < ZText.Length; i++)
                {
                    SzData[j] = ZData[j, i];
                    if (YMax < ZData[j, i])
                        YMax = ZData[j, i];
                }
            }

            double nY = YMax + YMax * 0.3;
            if (nY == 0)
            {
                this.ChartStyle = CharMode.none;
                YMax = 10;
                YHeightM = 100;
                Invalidate();
                return;
            }

            if (nY < 11)//设置X轴的刻度
            {
                YHeightM = (float)Math.Ceiling(nY);//Y轴的最大高度
                Xcou = (int)(Math.Ceiling(nY + 1));
                XData = new int[Xcou];//记录随机数据一维数组
                for (int i = 0; i < XData.Length; i++)
                    XData[i] = 0;
            }
            else
            {
                XData = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                YMax = (int)(Math.Ceiling(nY / 10));
                YHeightM = YMax * 10;//Y轴的最大高度
            }
        }
        #endregion

        #region 单列数据求和
        /// <summary>
        /// 单列数据求和
        /// </summary>
        public void RowStackedSum()
        {
            float Szsum = 0;
            YMax = 0;
            SzData = new float[XText.Length];
            for (int i = 0; i < XText.Length; i++)
            {
                Szsum = 0;
                for (int j = 0; j < ZText.Length; j++)
                    Szsum = Szsum + ZData[i, j];
                SzData[i] = Szsum;
                if (YMax < SzData[i])
                    YMax = SzData[i];
            }

            double nY = YMax + YMax * 0.2;

            if (nY == 0)
            {
                this.ChartStyle = CharMode.none;
                YMax = 10;
                YHeightM = 100;
                Invalidate();
                return;
            }
            if (nY < 11)//设置X轴的刻度
            {
                YHeightM = (float)Math.Ceiling(nY);//Y轴的最大高度
                Xcou = (int)Math.Ceiling(nY + 1);
                XData = new int[Xcou];//记录随机数据一维数组
                for (int i = 0; i < XData.Length; i++)
                    XData[i] = 0;
            }
            else
            {
                XData = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                YMax = (int)(Math.Ceiling(nY / 10));
                YHeightM = YMax * 10;//Y轴的最大高度
            }
        }
        #endregion

        #region 绘制图表的标题
        /// <summary>
        /// 绘制图表的标题
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        /// <returns>返回int对象</returns>
        private int ProtractTitle(Graphics g)
        {
            Brush BTitColor = new SolidBrush(this.TitleColor);
            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            string TitS = this.TitleName;//获取图表标题的名称
            SizeF TitSize = TitG.MeasureString(TitS, this.TitleFont);//将绘制的字符串进行格式化
            float TitWidth = TitSize.Width;//获取字符串的宽度
            TitHeight = TitSize.Height;//获取字符串的高度

            float TitX = 0;//标题的横向坐标
            float TitY = 0;//标题的纵向坐标
            int TitPlace = 0;//标题的位置
            switch (TitleStyle.ToString())
            {
                case "TopLeft":
                    {
                        TitY = this.FoulCalcar;
                        TitX = this.FoulCalcar;
                        TitPlace = 1;
                        break;
                    }
                case "TopCenter":
                    {
                        TitY = this.FoulCalcar;
                        TitX = (int)((this.Width - TitWidth) / 2);
                        TitPlace = 1;
                        break;
                    }
                case "TopRight":
                    {
                        TitY = this.FoulCalcar;
                        TitX = this.Width - TitWidth - this.FoulCalcar;
                        TitPlace = 1;
                        break;
                    }
                case "BottomLeft":
                    {
                        TitY = this.Height - TitHeight - this.FoulCalcar;
                        TitX = this.FoulCalcar;
                        TitPlace = 2;
                        break;
                    }
                case "BottomCenter":
                    {
                        TitY = this.Height - TitHeight - this.FoulCalcar;
                        TitX = (int)((this.Width - TitWidth) / 2);
                        TitPlace = 2;
                        break;
                    }
                case "BottomRight":
                    {
                        TitY = this.Height - TitHeight - this.FoulCalcar;
                        TitX = this.Width - TitWidth - this.FoulCalcar;
                        TitPlace = 2;
                        break;
                    }
            }

            //给制图表的标题
            if (this.TitleName == "")
                TitPlace = 0;
            else
                g.DrawString(this.TitleName, this.TitleFont, BTitColor, new PointF(TitX, TitY));
            return TitPlace;
        }
        #endregion

        #region 绘制图表的网格
        /// <summary>
        /// 获取绘制网格的基础信息
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        /// <param TitPlace="int">标题的位置</param>
        private void ProtractXY(Graphics g, int TitPlace)
        {
            mypen = new Pen(this.FoulLineColor, 1);//设置线的颜色及粗细
            mybrush = new SolidBrush(this.ChartColor);
            //获取X轴上最大标识符的高度和宽度
            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            SizeF XMaxSize = TitG.MeasureString(XText[0], this.PXYFont);//将绘制的字符串进行格式化
            int XMaxWidth = (int)(XMaxSize.Width);//获取字符串的宽度
            int XMaxHeight = (int)(XMaxSize.Height);//获取字符串的高度

            switch (TitPlace)//获取Y轴的高度
            {
                case 0:
                    {
                        YSize = this.Height - this.FoulCalcar * 2;
                        YUp = this.Height - (this.Height - this.FoulCalcar);
                        break;
                    }
                case 1:
                    {
                        YSize = this.Height - this.FoulCalcar * 3 - TitHeight;
                        YUp = this.Height - (this.Height - this.FoulCalcar * 2 - TitHeight);
                        break;
                    }
                case 2:
                    {
                        YSize = this.Height - this.FoulCalcar * 3 - TitHeight;
                        YUp = this.Height - (this.Height - this.FoulCalcar);
                        break;
                    }

            }

            if (this.TitleName == "")
            {
                YSize = YSize - XMaxHeight;
                YUp = YUp + XMaxHeight;
            }

            switch (this.ChartStyle)
            {
                case CharMode.Bar:
                case CharMode.Line:
                case CharMode.Mark:
                case CharMode.none:
                    { 
                        
                        ProtractBLMXY(g, XMaxWidth, XMaxHeight);
                        break;
                    }
                case CharMode.Area:
                    {
                        ProtractArea(g);
                        break;
                    }
            }
            
        }

        /// <summary>
        /// 绘制条形、线形、面形图表的网格
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        /// <param TitPlace="int">标题的位置</param>
        /// <param image="Bitmap">图片</param>
        private void ProtractBLMXY(Graphics g, int XMaxWidth, int XMaxHeight)
        {
            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            SizeF XMaxSize = TitG.MeasureString(XText[0], this.PXYFont);//将绘制的字符串进行格式化
            float nyh = 0;
            if (XData.Length < 10)//设置X轴的刻度
                nyh = YHeightM;
            else
                nyh = YMax * 10;

            //MessageBox.Show(YHeightM.ToString());

            SizeF YMaxSize = TitG.MeasureString(nyh.ToString(), this.PXYFont);//将绘制的字符串进行格式化
            float YMaxWidth = YMaxSize.Width;//获取字符串的宽度
            float YMaxHeight = YMaxSize.Height;//获取字符串的高度
            YUnit = (YSize - XMaxHeight - 5) / (XData.Length - 1);//纵向的单元格宽度

            if (this.ChartStyle == CharMode.Line || this.ChartStyle == CharMode.Mark)
            {
                if (this.LabelSay)
                    XSize = this.Width - this.FoulCalcar * 2 - YMaxWidth - 5;
                else
                {
                    XSize = this.Width - this.FoulCalcar * 2 - YMaxWidth - 5 - XMaxWidth / 2;
                }
            }
            else
                XSize = this.Width - this.FoulCalcar * 2 - YMaxWidth - 5;
            
            float YHeight = YUp + YUnit * (XData.Length - 1);
            XLeft = this.Width - (this.Width - this.FoulCalcar - YMaxWidth - 5);

            //当X轴的标识文字超出边线时，进行设置
            if (XMaxWidth / 2 > (YMaxWidth + 5))
            {
                XLeft = XLeft + (XMaxWidth / 2 - (YMaxWidth + 5));
                if (this.LabelSay == false)
                {
                    if (this.ChartStyle == CharMode.Bar)
                        XSize = XSize - (XMaxWidth / 2 - (YMaxWidth + 5)) * 2;
                    if (this.ChartStyle == CharMode.Line || this.ChartStyle == CharMode.Mark)
                        XSize = XSize - (Convert.ToSingle(XMaxWidth) / 2 - (YMaxWidth + 5));
                }
                else
                    XSize = XSize - (XMaxWidth / 2 - (YMaxWidth + 5));
            }
            //-----------------------------------

            temXLeft = XLeft;//获取图表的左边线的X坐标点
            if (LabelSay)//是否显示标签
            {
                ProtractLabelSay(g, YHeight - YUp);
            }

            if (this.ChartStyle == CharMode.Line || this.ChartStyle == CharMode.Mark)//设置X轴的单元大小
            {
                if (PageL == 1)
                    XUnit = XSize / 1;//如果条形图或面形图为一个值时
                else
                    XUnit = XSize / (PageL - 1);
            }
            else
                XUnit = XSize / PageL;
            float XWidth = 0;//设置X轴的长度
            if (this.ChartStyle == CharMode.Line || this.ChartStyle == CharMode.Mark)//获取X轴的长度
            {
                if (PageL == 1)//如果条形图或面形图为一个值时
                    XWidth = XLeft + XUnit;
                else
                    XWidth = XLeft + XUnit * (PageL - 1);
            }
            else
                XWidth = XLeft + XUnit * PageL;
            
            int fontAmong = 1;//当文字的宽度大于X轴上的单元格时，设置文本显示的间隔数
            long nn=0;//获取两数相除的余数
            if (XMaxWidth > XUnit)//判断X轴上的文字宽度是否大于单元格大小
            {
                fontAmong = (int)(Math.Ceiling(XMaxWidth / XUnit));//获取间隔数
            }

            YDown = YHeight;
            Pen temPen = new Pen(Color.Black, 1);//定义临时画笔
            penvoid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;//设置虚线
            int LMcount = 0;//设置X轴的列数
            if (this.ChartStyle == CharMode.Line || this.ChartStyle == CharMode.Mark)//获取X轴的列数
            {
                if (XText.Length == 1)
                    LMcount = 1;
                else
                    LMcount = XText.Length - 1;
            }
            else
                LMcount = XText.Length;
            float StrX = 0;//设置X轴文字的X坐标点
            float StrY = 0;//设置X轴文字的Y坐标点
            //mypen = new Pen(Color.Black, 1);
            //绘制线条
            //绘制纵向线条
            for (int i = 0; i <= LMcount; i++)
            {
                if (i == 0 || i == LMcount)
                    temPen = mypen;
                else
                    temPen = penvoid;
                g.DrawLine(temPen, XLeft, YUp, XLeft, YHeight);
                if (i != XText.Length)
                {
                    YMaxSize = TitG.MeasureString(XText[i], this.PXYFont);//将绘制的字符串进行格式化
                    YMaxWidth = (int)(YMaxSize.Width);//获取字符串的宽度
                    YMaxHeight = (int)(YMaxSize.Height);//获取字符串的高度
                    if (this.ChartStyle == CharMode.Line || this.ChartStyle == CharMode.Mark)
                    {
                        StrX = XLeft - YMaxWidth / 2;
                        StrY = YHeight + 5;
                    }
                    else
                    {
                        StrX = XLeft + (XUnit - YMaxWidth) / 2;
                        StrY = YHeight + 5;
                    }
                    if (i == 0)
                        g.DrawString(XText[i], this.PXYFont, BXYColor, new PointF(StrX, StrY));//绘制X轴的标识字体
                    else
                    { 
                        Math.DivRem((long)i,(long)fontAmong,out nn);
                        if (nn==0)
                            g.DrawString(XText[i], this.PXYFont, BXYColor, new PointF(StrX, StrY));//绘制X轴的标识字体
                    }

                }
                XLeft = XLeft + XUnit;
            }

            XLeft = temXLeft;
            //----------------------------------
            fontAmong = 1;//当文字的高度大于Y轴上的单元格时，设置文本显示的间隔数
            nn = 0;//获取两数相除的余数
            if (YMaxHeight > YUnit)//判断Y轴上的文字宽度是否大于单元高度
            {
                fontAmong = (int)(Math.Ceiling(YMaxHeight / YUnit));//获取间隔数
            }

            //绘制横向线条
            for (int i = 0; i < XData.Length; i++)//设置X轴的横向刻度
            {
                if (i == 0 || i == (XData.Length-1))////10
                    temPen = mypen;
                else
                    temPen = penvoid;
                g.DrawLine(temPen, XLeft, YUp, XWidth, YUp);//绘制横向线条
                if (XData.Length < 11)//设置X轴的横向刻度
                    nyh = (XData.Length - 1) - i;
                else
                    nyh = YHeightM - (YMax * i);
                YMaxSize = TitG.MeasureString(nyh.ToString(), this.PXYFont);//将绘制的字符串进行格式化
                YMaxWidth = YMaxSize.Width;//获取字符串的宽度
                YMaxHeight = YMaxSize.Height;//获取字符串的高度

                if (i == (XData.Length - 1))//绘制Y轴的标识字体
                {
                    if (this.ChartStyle == CharMode.Bar)
                    {
                        if (i == 0)
                            g.DrawString(nyh.ToString(), this.PXYFont, BXYColor, new PointF(XLeft - 5 - YMaxWidth, YUp - YMaxHeight / 2));//绘制Y轴的标识字体
                        else
                        {
                            Math.DivRem((long)i, (long)fontAmong, out nn);
                            if (nn == 0)
                                g.DrawString(nyh.ToString(), this.PXYFont, BXYColor, new PointF(XLeft - 5 - YMaxWidth, YUp - YMaxHeight / 2));//绘制Y轴的标识字体
                        }
                    }
                }
                else
                {
                    if (i == 0)
                        g.DrawString(nyh.ToString(), this.PXYFont, BXYColor, new PointF(XLeft - 5 - YMaxWidth, YUp - YMaxHeight / 2));//绘制Y轴的标识字体
                    else
                    {
                        Math.DivRem((long)i, (long)fontAmong, out nn);
                        if (nn == 0)
                            g.DrawString(nyh.ToString(), this.PXYFont, BXYColor, new PointF(XLeft - 5 - YMaxWidth, YUp - YMaxHeight / 2));//绘制Y轴的标识字体
                    }
                }
                XData[i] = Convert.ToInt32(nyh);
                YUp = YUp + YUnit;//设置横向线条的间距
            }
        }
        #endregion

        #region 显示标签说明文字
        /// <summary>
        /// 显示标签说明文字
        /// </summary>
        private void ProtractLabelSay(Graphics g, float YHeight)
        {
            string[] temText;//临时存储数据的名称数组
            string temTextSize = "";//存储最长的名称
            Font LSfont = new System.Drawing.Font("宋体", 8);
            if (this.ChartStyle != CharMode.Area)
            {
                if (ZText.Length > 1)
                    temText = ZText;
                else
                    temText = XText;
                for (int i = 0; i < temText.Length; i++)
                {
                    if (temText[i].Length > temTextSize.Length)
                        temTextSize = temText[i];
                }
            }
            else
            {
                temText = XText;
                float AresF = 0;

                for (int i = 0; i < temText.Length; i++)
                {
                    AresF = (SzData[i] / ASum) * 100;
                    AresF = (float)Math.Round(AresF,3);
                    temTextSize = temText[i] + " " + AresF.ToString() + "%";
                    if (temText[i].Length > temTextSize.Length)
                        temTextSize = temText[i];
                }
            }

            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            SizeF XMaxSize = TitG.MeasureString(temTextSize, LSfont);//将绘制的字符串进行格式化
            float XMaxWidth = XMaxSize.Width;//获取字符串的宽度
            float XMaxHeight = XMaxSize.Height;//获取字符串的高度

            LabelSayPlace(g, YHeight, temText, XMaxWidth, XMaxHeight, LSfont, 0, 0, 0, 0, 0, false);//绘制标签
        }

        /// <summary>
        /// 显示标签说明文字
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        /// <param YHeight="float">图表的高度</param>
        /// <param temText="string[]">标签名称的数组</param>
        /// <param XMaxWidth="float">最大字符串的宽度</param>
        /// <param XMaxHeight="float">最大字符串的高度</param>
        /// <param LSfont="Font">标签的字体样式</param>
        /// <param LSRcount="int">标签列的个数</param>
        /// <param TempL="float">字符串的X坐标</param>
        /// <param TempU="float">字符串的Y坐标</param>
        /// <param k="int">循环的起始点</param>
        /// <param p="int">循环的结束点</param>
        /// <param paint="bool">是否绘制</param>
        private void LabelSayPlace(Graphics g, float YHeight,string[] temText,float XMaxWidth,float XMaxHeight,Font LSfont,int Cp,float TempL,float TempU,int k,int p, bool paint)
        {
            float ClumpH = 12;//小方块的高度
            float ClumpW = 6;//小方块的宽度
            float remW = 6;//方块与边界的左右空隙
            float remH = 6;//方块与边界的上下空隙
            float bosom = 4;//标签之间的间隔
            float Wma = 7;//图表和标签之间的间隔
            float LSHeight = 0;//标签的高度
            float LSWidth = 0;//标签的宽度
            float LSLeft = 0;//设置标签左边线的位置
            float LSCount = 0;//标签的最大个数
            int CycCount = 0;//循环个数
            int LSRcount = 0;//标签的列数
            float AreaF = 0;//记录百分比
            string AreaS = "";//记录标识文字

            if (!paint)
            {
                LSHeight = temText.Length * ClumpH + (temText.Length - 1) * bosom + remH * 2;//获取标签的高度

                if (LSHeight >= YHeight)
                {
                    double mm = (YHeight - remH - (remH - bosom)) / (ClumpH + bosom);
                    LSCount = (float)(Math.Floor(mm));
                    LSHeight = LSCount * ClumpH + (LSCount - 1) * bosom + remH * 2;
                    LSCount = (float)(Math.Floor((LSHeight - remH - (remH - bosom)) / (ClumpH + bosom)));
                    if (LSHeight < (remH * 2 + ClumpH))
                        return;
                    CycCount = (int)LSCount;
                    LSRcount = (int)(Math.Ceiling(Convert.ToDouble(temText.Length) / (Convert.ToDouble(CycCount))));
                    LSWidth = (ClumpW + remW + XMaxWidth) * LSRcount + remW * 2;
                    if (LSWidth > (this.Width - this.FoulCalcar * 2))
                        return;
                    XSize = Convert.ToInt32(XSize - Wma - LSWidth) - 2;//获取图表的宽度
                    k = 0;
                    p = CycCount;
                }
                else
                {
                    LSWidth = ClumpW + remW * 3 + XMaxWidth;//获取标签的宽度
                    XSize = Convert.ToInt32(XSize - Wma - LSWidth) - 2;//获取图表的宽度
                    CycCount = temText.Length;
                    k = 0;
                    p = CycCount;
                }

                LSLeft = temXLeft + XSize + Wma - 2;//获取标签左边线的位置
                if (this.ChartStyle == CharMode.Area)
                    LSLeft = temXLeft + XSize + Wma;

                g.FillRectangle(Brushes.Gainsboro, LSLeft, YUp, LSWidth, LSHeight);//绘制内矩形
                g.DrawRectangle(new Pen(Color.Black, 1), LSLeft, YUp, LSWidth, LSHeight);//绘制矩形
                TempU = YUp + remH;//小方块的Y坐标
                TempL = LSLeft + remW;//小方块的X坐标

                LabelSayPlace(g, YHeight, temText, XMaxWidth, XMaxHeight, LSfont, CycCount, TempL, TempU, k, p, true);//调用本方法，绘制标签文字
            }
            else
            {
                int t = 0;
                for (int i = k; i < p; i++)//循环绘制每列的标签文字
                {
                    if (this.ChartStyle == CharMode.Area)
                    {
                        if (i >= WearColor.Length)
                        {
                            mybrush = new SolidBrush(WearColor[i - WearColor.Length]);
                        }
                        else
                        {
                            mybrush = new SolidBrush(WearColor[i]);
                        }
                    }
                    else
                    {
                        if (ZText.Length > 1)//如果每列有多个数据，设置小方模块的颜色为不同的颜色
                        {
                            if (i >= WearColor.Length)
                            {
                                if (this.ChartStyle == CharMode.Line)
                                    mypen = new Pen(WearColor[i - WearColor.Length], 1);
                                else
                                    mybrush = new SolidBrush(WearColor[i - WearColor.Length]);
                            }
                            else
                            {
                                if (this.ChartStyle == CharMode.Line)
                                    mypen = new Pen(WearColor[i], 1);
                                else
                                    mybrush = new SolidBrush(WearColor[i]);
                            }
                        }
                        else
                        {
                            if (this.ChartStyle == CharMode.Line || this.ChartStyle == CharMode.Mark)
                            {
                                if (this.ChartStyle == CharMode.Line)
                                    mypen = new Pen(this.ChartColor, 1);
                                else
                                    mybrush = new SolidBrush(this.ChartColor);
                            }
                            else
                            {
                                if (this.ChartWearColor)//当用多颜色显示不同数据时，设置小方模块的颜色为不同的颜色
                                {
                                    if (i >= WearColor.Length)
                                    {
                                        mybrush = new SolidBrush(WearColor[i - WearColor.Length]);
                                    }
                                    else
                                    {
                                        mybrush = new SolidBrush(WearColor[i]);
                                    }
                                }
                                else//以默认颜色来显示数据条
                                {
                                    mybrush = new SolidBrush(this.ChartColor);
                                }
                            }
                        }
                    }

                    Graphics TitG = this.CreateGraphics();//创建Graphics类对象
                    if (this.ChartStyle == CharMode.Line)
                        g.DrawLine(mypen, TempL, TempU + ClumpH / 2, TempL + ClumpW, TempU + ClumpH / 2);//绘制线形
                    else
                        g.FillRectangle(mybrush, TempL, TempU, ClumpW, ClumpH);//绘制小方块
                    if (this.ChartStyle == CharMode.Area)
                    {
                        AreaF = (SzData[i] / ASum) * 100;
                        AreaF = (float)Math.Round(AreaF, 2);
                        AreaS = temText[i] + "  " + AreaF.ToString() + "%";
                    }
                    else
                        AreaS = temText[i];

                    SizeF XMaxSize = TitG.MeasureString(AreaS, LSfont);//将绘制的字符串进行格式化
                    XMaxHeight = XMaxSize.Height;//获取字符串的高度
                    g.DrawString(AreaS, new Font("宋体", 8), new SolidBrush(Color.Black), new PointF(TempL + remW * 2, TempU + (ClumpH - XMaxHeight) / 2));
                    TempU = TempU + ClumpH + bosom;
                }
                if (p != temText.Length)//如果没有绘制到标签尾
                {
                    t = p;
                    if ((p + Cp) > temText.Length)//如果下一次循环到尾部
                        p = temText.Length;
                    else
                        p = p + Cp;
                    k = t;

                    TempU = YUp + remH;//小方块的Y坐标
                    TempL = TempL + remW + XMaxWidth + ClumpW;//小方块的X坐标
                    LabelSayPlace(g, YHeight, temText, XMaxWidth, XMaxHeight, LSfont, Cp, TempL, TempU, k, p, true);
                }
            }
        }
        #endregion

        #region 绘制条形图(Bar)
        /// <summary>
        /// 绘制条形图
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        private void ProtractBar(Graphics g)
        {
            //显示柱状效果
            Font Zfont = new System.Drawing.Font("Arial", 8);
            SolidBrush Zbrush = new SolidBrush(Color.Black);
            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            SizeF YMaxSize = TitG.MeasureString("", this.PXYFont);//将绘制的字符串进行格式化
            XLeft = temXLeft;
            float UnitSp = (float)(XUnit * 0.2);//设置矩形与纵线的间隔
            float A1 = 0;//记录矩形的X点
            float A2 = 0;//记录矩形的Y点
            float A3 = 0;//记录矩形的宽度
            float A4 = 0;//记录矩形的高度
            int XLinage = 0;//记录数值在最大水平线的行数
            float XValue = 0;//记录数值高于最大水平线的值
            bool XParity = false;//是否有与X轴的标识相等的值
            double XDegree = 0.0;//当窗体的坐标点小于X轴的刻度时，记录每刻度的坐标点大小
            int rowcon = 1;//记录每列的个数
            bool bl = true;//记录数据是否为0
            //Side属性的设置
            if ((RowL > 1 && this.RowWeave == CharRowWeaveStyle.Side) || RowL == 1)////-----////
            {

                for (int k = 0; k < XText.Length; k++)//循环X轴上的数据
                {
                    if (ZText.Length > 1)//当列数据的个数大于1时
                    {
                        UnitSp = (float)(XUnit * 0.1);//设置矩形与纵线的间隔
                        rowcon = 0;
                        for (int i = 0; i < ZText.Length; i++)//获取列数据不为0的个数
                        {
                            if (ZData[k, i] != 0)
                                rowcon = rowcon + 1;
                        }
                    }
                    A1 = XLeft + UnitSp;
                    
                    for (int i = 0; i < ZText.Length; i++)//循环列中的数据
                    {
                        bl = true;
                        for (int j = 0; j < XData.Length; j++)
                        {
                            if (ZText.Length > 1 && ZData[k, i] == 0)
                            {
                                bl = false;
                                break;
                            }
                            if (ZData[k, i] >= XData[j])
                            {
                                if (ZData[k, i] == XData[j])
                                {
                                    XParity = true;
                                    XLinage = XData.Length - j - 1;
                                }
                                else
                                {
                                    XParity = false;
                                    XLinage = XData.Length - j;
                                }
                                XValue = XData[j];
                                break;
                            }
                        }

                        XValue = ZData[k, i] - XValue;

                        if (XParity)
                            A4 = YUnit * XLinage;
                        else
                        {
                            if (YUnit >= YMax)
                                A4 = YUnit * (XLinage - 1) + (YUnit / YMax * XValue);
                            else
                            {
                                XDegree = Convert.ToDouble(YUnit) / Convert.ToDouble(YMax);
                                XDegree = XDegree * XValue;
                                A4 = YUnit * (XLinage - 1) + (float)XDegree;
                            }
                        }
                        A2 = YDown - A4;
                        A3 = (XUnit - UnitSp * 2) / (float)rowcon;
                        if (ZText.Length > 1)
                        {
                            if (i >= WearColor.Length)
                                mybrush = new SolidBrush(WearColor[i - WearColor.Length]);
                            else
                                mybrush = new SolidBrush(WearColor[i]);
                        }
                        else
                        {
                            if (this.ChartWearColor)
                            {
                                if (i >= WearColor.Length)
                                    mybrush = new SolidBrush(WearColor[k - WearColor.Length]);
                                else
                                    mybrush = new SolidBrush(WearColor[k]);
                            }
                            else
                            {
                                mybrush = new SolidBrush(this.ChartColor);
                            }
                        }
                        if (bl == true)
                        {
                            g.FillRectangle(mybrush, A1, A2, A3, A4);//显示柱状效果
                            A1 = A1 + A3;
                        }
 
                    }
                    XLeft = XLeft + XUnit;
                }
                if (this.Chartmark)
                    ProtractBarFont(g);
            }
            //Stacked属性的设置
            float temSum = 0;
            if ((RowL > 1 && this.RowWeave == CharRowWeaveStyle.Stavked))
            {
                for (int k = 0; k < XText.Length; k++)//循环X轴上的数据
                {
                    A1 = XLeft + UnitSp;
                    temSum = 0;
                    for (int i = 0; i < ZText.Length; i++)//循环列中的数据
                    {
                        bl = true;
                        for (int j = 0; j < XData.Length; j++)
                        {
                            if (ZData[k, i] == 0)
                                bl = false;
                            if (ZData[k, i] >= XData[j])
                            {
                                if (ZData[k, i] == XData[j])
                                {
                                    XParity = true;
                                    XLinage = XData.Length - j - 1;
                                }
                                else
                                {
                                    XParity = false;
                                    XLinage = XData.Length - j;
                                }
                                XValue = XData[j];
                                break;
                            }
                        }
                        XValue = ZData[k, i] - XValue;

                        if (XParity)
                            A4 = YUnit * XLinage;
                        else
                        {
                            if (YUnit >= YMax)
                                A4 = YUnit * (XLinage - 1) + (YUnit / YMax * XValue);
                            else
                            {
                                XDegree = Convert.ToDouble(YUnit) / Convert.ToDouble(YMax);
                                XDegree = XDegree * XValue;
                                A4 = YUnit * (XLinage - 1) + (float)XDegree;
                            }
                        }
                        A2 = YDown - A4;
                        A3 = XUnit - UnitSp * 2;

                        if (i >= WearColor.Length)
                            mybrush = new SolidBrush(WearColor[i - WearColor.Length]);
                        else
                            mybrush = new SolidBrush(WearColor[i]);
                        if (i == 0)
                            temSum = A2;
                        else
                            temSum = temSum - A4;
                        if (bl == true)
                            g.FillRectangle(mybrush, A1, temSum, A3, A4);//显示柱状效果

                    }
                    temSum = 0;
                    XLeft = XLeft + XUnit;
                }
                if (this.Chartmark)
                    ProtractBarFont(g);

            }

        }
        #endregion

        #region 绘制条形图标识文字(Bar Sign)
        /// <summary>
        /// 绘制条形图
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        private void ProtractBarFont(Graphics g)
        {
            //显示柱状效果
            Font Zfont = new System.Drawing.Font("Arial", 8);
            SolidBrush Zbrush = new SolidBrush(Color.Black);
            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            SizeF YMaxSize = TitG.MeasureString("", this.PXYFont);//将绘制的字符串进行格式化
            float YMaxWidth = 0;//获取字符串的宽度
            float YMaxHeight = 0;//获取字符串的高度
            XLeft = temXLeft;
            float UnitSp = (float)(XUnit * 0.2);//设置矩形与纵线的间隔
            float A1 = 0;//记录矩形的X点
            float A2 = 0;//记录矩形的Y点
            float A3 = 0;//记录矩形的宽度
            float A4 = 0;//记录矩形的高度
            int XLinage = 0;//记录数值在最大水平线的行数
            float XValue = 0;//记录数值高于最大水平线的值
            bool XParity = false;//是否有与X轴的标识相等的值
            double XDegree = 0.0;//当窗体的坐标点小于X轴的刻度时，记录每刻度的坐标点大小
            int rowcon = 1;//记录每列的个数
            float Fsign = 0;//记录数据标识文字的X轴位置
            bool bl = true;//记录数据是否为0

            //Side样式的标识文字
            if ((RowL > 1 && this.RowWeave == CharRowWeaveStyle.Side) || RowL == 1)////////------/////
            {
                for (int k = 0; k < XText.Length; k++)//循环X轴上的数据
                {
                    if (ZText.Length > 1)//当列数据的个数大于1时
                    {
                        UnitSp = (float)(XUnit * 0.1);//设置矩形与纵线的间隔
                        rowcon = 0;
                        for (int i = 0; i < ZText.Length; i++)//获取列数据不为0的个数
                        {
                            if (ZData[k, i] != 0)
                                rowcon = rowcon + 1;
                        }
                    }
                    A1 = XLeft + UnitSp;
                    for (int i = 0; i < ZText.Length; i++)//循环列中的数据
                    {
                        bl = true;
                        for (int j = 0; j < XData.Length; j++)
                        {
                            if (ZText.Length > 1 && ZData[k, i] == 0)
                                bl=false;
                            if (ZData[k, i] >= XData[j])
                            {
                                if (ZData[k, i] == XData[j])
                                {
                                    XParity = true;
                                    XLinage = XData.Length - j - 1;
                                }
                                else
                                {
                                    XParity = false;
                                    XLinage = XData.Length - j;
                                }
                                XValue = XData[j];
                                break;
                            }
                        }
                        XValue = ZData[k, i] - XValue;

                        if (XParity)
                            A4 = YUnit * XLinage;
                        else
                        {
                            if (YUnit >= YMax)
                                A4 = YUnit * (XLinage - 1) + (YUnit / YMax * XValue);
                            else
                            {
                                XDegree = Convert.ToDouble(YUnit) / Convert.ToDouble(YMax);
                                XDegree = XDegree * XValue;
                                A4 = YUnit * (XLinage - 1) + (float)XDegree;
                            }
                        }
                        A2 = YDown - A4;
                        A3 = (XUnit - UnitSp * 2) / (float)rowcon;

                        YMaxSize = TitG.MeasureString(ZData[k, i].ToString(), Zfont);//将绘制的字符串进行格式化
                        YMaxWidth = YMaxSize.Width;//获取字符串的宽度
                        YMaxHeight = YMaxSize.Height;//获取字符串的高度
                        if (YMaxWidth < A3)
                            Fsign = (float)(A1 + (A3 - YMaxWidth) / 2);
                        else
                        {
                            if ((YMaxWidth - A3) != 0)
                                Fsign = (float)(A1 - (YMaxWidth - A3) / 2);
                            else
                                Fsign = (float)A1;
                        }
                        if (bl == true)
                        {
                            g.DrawString(ZData[k, i].ToString(), Zfont, Zbrush, new PointF(Fsign, A2 - 2 - YMaxHeight));
                            A1 = A1 + A3;
                        }
                    }
                    XLeft = XLeft + XUnit;
                }
            }

            //Stacked样式的标识文字
            float temSum = 0;
            if ((RowL > 1 && this.RowWeave == CharRowWeaveStyle.Stavked))// || this.RowList == 1)
            {
                for (int k = 0; k < XText.Length; k++)//循环X轴上的数据
                {
                    A1 = XLeft + UnitSp;
                    temSum = 0;
                    for (int i = 0; i < ZText.Length; i++)//循环列中的数据
                    {
                        bl = true;
                        for (int j = 0; j < XData.Length; j++)
                        {
                            if (ZData[k, i] == 0)
                                bl = false;
                            if (ZData[k, i] >= XData[j])
                            {
                                if (ZData[k, i] == XData[j])
                                {
                                    XParity = true;
                                    XLinage = XData.Length - j - 1;
                                }
                                else
                                {
                                    XParity = false;
                                    XLinage = XData.Length - j;
                                }
                                XValue = XData[j];
                                break;
                            }
                        }
                        XValue = ZData[k, i] - XValue;

                        if (XParity)
                            A4 = YUnit * XLinage;
                        else
                        {
                            if (YUnit >= YMax)
                                A4 = YUnit * (XLinage - 1) + (YUnit / YMax * XValue);
                            else
                            {
                                XDegree = Convert.ToDouble(YUnit) / Convert.ToDouble(YMax);
                                XDegree = XDegree * XValue;
                                A4 = YUnit * (XLinage - 1) + (float)XDegree;
                            }
                        }
                        A2 = YDown - A4;
                        A3 = XUnit - UnitSp * 2;

                        if (i == 0)
                            temSum = A2;
                        else
                            temSum = temSum - A4;

                        YMaxSize = TitG.MeasureString(ZData[k, i].ToString(), Zfont);//将绘制的字符串进行格式化
                        YMaxWidth = YMaxSize.Width;//获取字符串的宽度
                        YMaxHeight = YMaxSize.Height;//获取字符串的高度
                        if (YMaxWidth < A3)
                            Fsign = (float)(A1 + (A3 - YMaxWidth) / 2);
                        else
                        {
                            if ((YMaxWidth - A3) != 0)
                                Fsign = (float)(A1 - (YMaxWidth - A3) / 2);
                            else
                                Fsign = (float)A1;
                        }
                        if (bl == true)
                            g.DrawString(ZData[k, i].ToString(), Zfont, Zbrush, new PointF(Fsign, temSum - 2 - YMaxHeight));

                    }
                    temSum = 0;
                    XLeft = XLeft + XUnit;
                }
            }
        }
        #endregion

        #region 绘制线形或面形图(Line、Mark)
        /// <summary>
        /// 绘制线形或面形图(Line、Mark)
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        private void ProtractLM(Graphics g)
        {
            //显示线形效果
            Font Zfont = new System.Drawing.Font("Arial", 8);
            SolidBrush Zbrush = new SolidBrush(Color.Black);
            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            SizeF YMaxSize = TitG.MeasureString("", this.PXYFont);//将绘制的字符串进行格式化
            XLeft = temXLeft;
            float UnitSp = (float)(XUnit * 0.2);//设置矩形与纵线的间隔
            float A1 = 0;//记录矩形的X点
            float A3 = 0;
            float A4 = 0;//记录矩形的高度
            //记录面形图表的各点坐标
            PointF PF1 = new PointF(0, 0);
            PointF PF2 = new PointF(0, 0);
            PointF PF3 = new PointF(0, 0);
            PointF PF4 = new PointF(0, 0);

            int XLinage = 0;//记录数值在最大水平线的行数
            float XValue = 0;//记录数值高于最大水平线的值
            bool XParity = false;//是否有与X轴的标识相等的值
            double XDegree = 0.0;//当窗体的坐标点小于X轴的刻度时，记录每刻度的坐标点大小
            float Linker = 0;//记录连接点的数值
            PointF[] curvePoints;//记录面形图表的坐标数组
            Pen Lmypen = new Pen(Color.Black, 1);
            float[] Xsum = new float[XText.Length];

            for (int i = 0; i < Xsum.Length; i++)
                Xsum[i] = 0;

            for (int k = 0; k < ZText.Length; k++)//遍历X轴上每列的个数
            {
                A1 = XLeft;

                for (int i = 0; i < XText.Length; i++)//遍历X轴上的列数
                {
                    for (int j = 0; j < XData.Length; j++)//遍历Y轴上的刻度值
                    {
                        if (ZData[i, k] >= XData[j])//如果当前值大于等于X轴上的刻度值
                        {
                            if (ZData[i, k] == XData[j])//如果当前值等于X轴上的刻度值
                            {
                                XParity = true;//进行标识
                                XLinage = XData.Length - j - 1;//因为X轴上的刻度值是从大到小排序的，所以取反
                            }
                            else//如果当前值小于X轴上的刻度值
                            {
                                XParity = false;//进行标识
                                XLinage = XData.Length - j;//获取当前值大于相应的X轴刻度值
                            }
                            XValue = XData[j];//获取当前值与X轴刻度相比的最小刻度值
                            break;
                        }
                    }
                    XValue = ZData[i, k] - XValue;//获取当前值与X轴刻度的差

                    if (XParity)//如果当前值等于X轴的刻度
                        A4 = YUnit * XLinage;//获取当前值的高度
                    else
                    {
                        if (YUnit >= YMax)//如果X轴每单元的刻度值大于每单元的实际刻度
                            A4 = YUnit * (XLinage - 1) + (YUnit / YMax * XValue);
                        else
                        {
                            XDegree = Convert.ToDouble(YUnit) / Convert.ToDouble(YMax);
                            XDegree = XDegree * XValue;
                            A4 = YUnit * (XLinage - 1) + (float)XDegree;
                        }
                    }

                    if (PageL == 1)//如果条形图或面形图为一个值时
                    {
                        if (ZText.Length > 1)
                        {
                            if (k >= WearColor.Length)
                                mybrush = new SolidBrush(WearColor[k - WearColor.Length]);
                            else
                                mybrush = new SolidBrush(WearColor[k]);
                        }
                        else
                        {
                            mybrush = new SolidBrush(this.ChartColor);
                        }

                        g.FillEllipse(mybrush, A1 - 1, YDown - A4 - 1, 3, 3);
                    }
                    else
                    {
                        if (i != 0)//当前值不在X轴的0刻度上
                        {
                            if (ZText.Length > 1)//如果每列中的个数大1
                            {
                                if (this.ChartStyle == CharMode.Line)//如果是线形图
                                {
                                    if (k >= WearColor.Length)//如果列中的个数大于自定义的颜色数组个数
                                        Lmypen = new Pen(WearColor[k - WearColor.Length], 1);//设置线的颜色及粗细
                                    else
                                        Lmypen = new Pen(WearColor[k], 1);
                                }
                                if (this.ChartStyle == CharMode.Mark)//如果是面形图
                                {
                                    if (k >= WearColor.Length)
                                        mybrush = new SolidBrush(WearColor[k - WearColor.Length]);
                                    else
                                        mybrush = new SolidBrush(WearColor[k]);
                                }
                            }
                            else
                            {
                                if (this.ChartStyle == CharMode.Line)//如果是线形图
                                {
                                    Lmypen = new Pen(this.ChartColor, 1);
                                }
                                if (this.ChartStyle == CharMode.Mark)//如果是面形图
                                {
                                    mybrush = new SolidBrush(this.ChartColor);
                                }
                            }

                            if (this.ChartStyle == CharMode.Line)//如果是线形图
                            {
                                g.DrawLine(Lmypen, A1, Linker, A1 + XUnit, YDown - A4);//绘制线条
                            }

                            if (this.ChartStyle == CharMode.Mark)//如果是面形图
                            {
                                
                                //设置绘制面形图的4个点
                                if (i == 1)//如要绘制的是第一个平面，使平面不覆盖Y轴
                                {
                                    if (this.RowWeave == CharRowWeaveStyle.Side)
                                    {
                                        PF1 = new PointF(A1 + 1, YDown);
                                        PF2 = new PointF(A1 + 1, Linker);
                                    }
                                    if (this.RowWeave == CharRowWeaveStyle.Stavked)
                                    {
                                        if (k == 0)
                                        {
                                            PF1 = new PointF(A1 + 1, YDown);
                                            PF2 = new PointF(A1 + 1, Linker);
                                        }
                                        else
                                        {
                                            PF1 = new PointF(A1 + 1, YDown - Xsum[i - 1] + A3);
                                            PF2 = new PointF(A1 + 1, YDown - Xsum[i - 1]);
                                        }
                                    }
                                }
                                else
                                {
                                    if (this.RowWeave == CharRowWeaveStyle.Side)
                                    {
                                        PF1 = new PointF(A1, YDown);
                                        PF2 = new PointF(A1, Linker);
                                    }
                                    if (this.RowWeave == CharRowWeaveStyle.Stavked)
                                    {
                                        if (k == 0)
                                        {
                                            PF1 = new PointF(A1, YDown);
                                            PF2 = new PointF(A1, Linker);
                                        }
                                        else
                                        {
                                            PF1 = new PointF(A1, YDown - Xsum[i - 1]+ A3);
                                            PF2 = new PointF(A1, YDown - Xsum[i - 1] );
                                        }
                                    }
                                }
                                if (this.RowWeave == CharRowWeaveStyle.Side)
                                {
                                    PF3 = new PointF(A1 + XUnit, YDown - A4);
                                    PF4 = new PointF(A1 + XUnit, YDown);
                                }
                                if (this.RowWeave == CharRowWeaveStyle.Stavked)
                                {
                                    if (k == 0)
                                    {
                                        PF3 = new PointF(A1 + XUnit, YDown - A4);
                                        PF4 = new PointF(A1 + XUnit, YDown);
                                    }
                                    else
                                    {
                                        PF3 = new PointF(A1 + XUnit, YDown - A4 - Xsum[i]);
                                        PF4 = new PointF(A1 + XUnit, YDown - Xsum[i]);
                                    }
                                }
                                curvePoints = new PointF[] { PF1, PF2, PF3, PF4 };//定义成点数组
                                g.FillPolygon(mybrush, curvePoints);//绘制面形图
                                g.DrawPolygon(new Pen(Color.Black, (float)(0.2)), curvePoints);
                                if (this.RowWeave == CharRowWeaveStyle.Stavked)
                                    Xsum[i] = A4 + Xsum[i];
                            }
                            Linker = YDown - A4;
                            A3 = A4;
                            A1 = A1 + XUnit;
                        }
                        else
                        {
                            if (this.ChartStyle == CharMode.Mark)//如果是面形图
                            {

                                A3 = A4;
                                if (this.RowWeave == CharRowWeaveStyle.Stavked)
                                {
                                    if (k != 0)
                                        Xsum[i] = A3 + Xsum[i];
                                    else
                                        Xsum[i] = A4 + Xsum[i];
                                }
                                
                            }

                            Linker = YDown - A4;

                        }
                    }
                }


            }
            ProtractLMSign(g);
        }


        #endregion

        #region 绘制线形或面形图(Line、Mark)的标识文字
        /// <summary>
        /// 绘制线形或面形图(Line、Mark)
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        private void ProtractLMSign(Graphics g)
        {

            //显示线形效果
            Font Zfont = new System.Drawing.Font("Arial", 8);
            SolidBrush Zbrush = new SolidBrush(Color.Black);
            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            SizeF YMaxSize = TitG.MeasureString("", this.PXYFont);//将绘制的字符串进行格式化
            float YMaxWidth = 0;//获取字符串的宽度
            float YMaxHeight = 0;//获取字符串的高度

            XLeft = temXLeft;
            float UnitSp = (float)(XUnit * 0.2);//设置矩形与纵线的间隔
            float A1 = 0;//记录矩形的X点
            float A4 = 0;//记录矩形的高度

            int XLinage = 0;//记录数值在最大水平线的行数
            float XValue = 0;//记录数值高于最大水平线的值
            bool XParity = false;//是否有与X轴的标识相等的值
            double XDegree = 0.0;//当窗体的坐标点小于X轴的刻度时，记录每刻度的坐标点大小

            float[] Xsum = new float[XText.Length];

            for (int i = 0; i < Xsum.Length; i++)
                Xsum[i] = 0;

            if (this.Chartmark)
            {

                for (int k = 0; k < ZText.Length; k++)//遍历X轴上每列的个数
                {
                    A1 = XLeft;
                    for (int i = 0; i < XText.Length; i++)//遍历X轴上的列数
                    {
                        for (int j = 0; j < XData.Length; j++)//遍历Y轴上的刻度值
                        {
                            if (ZData[i, k] >= XData[j])//如果当前值大于等于X轴上的刻度值
                            {
                                if (ZData[i, k] == XData[j])//如果当前值等于X轴上的刻度值
                                {
                                    XParity = true;//进行标识
                                    XLinage = XData.Length - j - 1;//因为X轴上的刻度值是从大到小排序的，所以取反
                                }
                                else//如果当前值小于X轴上的刻度值
                                {
                                    XParity = false;//进行标识
                                    XLinage = XData.Length - j;//获取当前值大于相应的X轴刻度值
                                }
                                XValue = XData[j];//获取当前值与X轴刻度相比的最小刻度值
                                break;
                            }
                        }
                        XValue = ZData[i, k] - XValue;//获取当前值与X轴刻度的差

                        if (XParity)//如果当前值等于X轴的刻度
                            A4 = YUnit * XLinage;//获取当前值的高度
                        else
                        {
                            if (YUnit >= YMax)//如果X轴每单元的刻度值大于每单元的实际刻度
                                A4 = YUnit * (XLinage - 1) + (YUnit / YMax * XValue);
                            else
                            {
                                XDegree = Convert.ToDouble(YUnit) / Convert.ToDouble(YMax);
                                XDegree = XDegree * XValue;
                                A4 = YUnit * (XLinage - 1) + (float)XDegree;
                            }
                        }

                        YMaxSize = TitG.MeasureString(ZData[i, k].ToString(), Zfont);//将绘制的字符串进行格式化
                        YMaxWidth = YMaxSize.Width;//获取字符串的宽度
                        YMaxHeight = YMaxSize.Height;//获取字符串的高度

                        if (this.ChartStyle == CharMode.Mark)
                        {
                            if (this.RowWeave == CharRowWeaveStyle.Stavked)
                            {
                                Xsum[i] = Xsum[i] + A4;
                                g.DrawString(ZData[i, k].ToString(), Zfont, Zbrush, new PointF(A1 - YMaxWidth / 2, (YDown - Xsum[i]) - 2 - YMaxHeight));
                            }
                            if (this.RowWeave == CharRowWeaveStyle.Side)
                            {
                                g.DrawString(ZData[i, k].ToString(), Zfont, Zbrush, new PointF(A1 - YMaxWidth / 2, (YDown - A4) - 2 - YMaxHeight));
                            }
                        }
                        if (this.ChartStyle == CharMode.Line)
                        {
                            g.DrawString(ZData[i, k].ToString(), Zfont, Zbrush, new PointF(A1 - YMaxWidth / 2, (YDown - A4) - 2 - YMaxHeight));
                        }

                        A1 = A1 + XUnit;
                    }
                }
            }
        }
        #endregion

        #region 绘制饼形图(Area)


        public static string[] AreaText;//临时存储数据的名称数组
        public static float AreaXMaxWidth = 0;//获取字符串的宽度
        public static float AreaXMaxHeight = 0;//获取字符串的高度
        public static float Aline = 20;//标识文字的前端线长
        public static float Asash = 3;//标识文本名边框的宽度
        //获取饼形图的标识文字
        public void AreaValue()
        {
            string temTextSize = "";//存储最长的名称
            Font LSfont = new System.Drawing.Font("宋体", 8);
            AreaText = new string[XText.Length];
            for (int i = 0; i < XText.Length; i++)
            {
                AreaText[i] = XText[i];
            }
            float AresF = 0;

            for (int i = 0; i < AreaText.Length; i++)
            {
                AresF = (SzData[i] / ASum) * 100;
                AresF = (float)Math.Round(AresF, 3);
                
                AreaText[i] = AreaText[i] + " " + AresF.ToString() + "%";
                if (AreaText[i].Length > temTextSize.Length)
                {
                    temTextSize = AreaText[i];
                }
            }
            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            SizeF XMaxSize = TitG.MeasureString(temTextSize + Asash * 2, LSfont);//将绘制的字符串进行格式化
            AreaXMaxWidth = XMaxSize.Width;//获取字符串的宽度
            AreaXMaxHeight = XMaxSize.Height;//获取字符串的高度
        }

        //绘制饼形图表
        public void ProtractArea(Graphics g)
        {
            AreaValue();
            mypen = new Pen(Color.Black, 1);
            float f = 0;
            float TimeNum = 0;
            float AXLeft = 0;
            float AYUp = 0;
            float AXSize = 0;
            float AYSize = 0;
            float Atop = 0;
            float Aleft = 0;
            TimeNum = this.AreaAngle;//-------
            XLeft = this.Width - (this.Width - this.FoulCalcar);
            XSize = this.Width - this.FoulCalcar * 2;
            AYUp = YUp;
            AYSize = YSize;
            temXLeft = AXLeft;
            if (this.LabelSay)//是否显示标签
            {
                ProtractLabelSay(g, this.Height - this.FoulCalcar * 3 - TitHeight);

            }
            AXLeft = XLeft;
            AXSize = XSize;
            AYUp = YUp;
            AYSize = YSize;

            if (this.Chartmark == true)
            {
                AXLeft = AXLeft + AreaXMaxWidth + Aline;
                AYUp = AYUp + AreaXMaxHeight;
                AXSize = XSize - AreaXMaxWidth * 2 - Aline * 2;
                AYSize = YSize - AreaXMaxHeight * 2;

                if (AXSize >= AYSize)
                {
                    Aleft = AXSize - AYSize;
                    AXSize = AYSize;
                }
                else
                {
                    Atop = AYSize - AXSize;
                    AYSize = AXSize;
                }
                if (Aleft != 0)
                {
                    AXLeft = AXLeft + Aleft / 2;
                }
                if (Atop != 0)
                {
                    AYUp = AYUp + Atop / 2;
                }
            }
            temXLeft = XLeft;

            if (AXSize > 0 && AYSize > 0)
            {
                for (int i = 0; i < SzData.Length; i++)
                {
                    f = SzData[i] / ASum;
                    if (i >= WearColor.Length)
                        mybrush = new SolidBrush(WearColor[i - WearColor.Length]);
                    else
                        mybrush = new SolidBrush(WearColor[i]);
                    g.FillPie(mybrush, AXLeft, AYUp, AXSize, AYSize, TimeNum, f * 360);
                    TimeNum += f * 360;
                }

                if (this.Chartmark == true)
                {
                    ProAreaSign(g);
                }
            }
            else
                return;
        }
        #endregion

        #region 绘制饼形图标识(Area)
        public void ProAreaSign(Graphics g)
        {
            AreaValue();
            mypen = new Pen(Color.Black, 1);
            Font LSfont = new System.Drawing.Font("宋体", 8);
            SolidBrush Zbrush = new SolidBrush(Color.Black);
            SolidBrush ATbrush = new SolidBrush(Color.Khaki);
            float f = 0;
            float TimeNum = 0;
            float AXLeft = 0;
            float AYUp = 0;
            float AXSize = 0;
            float AYSize = 0;
            float Atop = 0;
            float Aleft = 0;
            Graphics TitG = this.CreateGraphics();//创建Graphics类对象
            SizeF XMaxSize = TitG.MeasureString("", LSfont);//将绘制的字符串进行格式化
            float SWidth = 0;//获取字符串的宽度
            float SHeight = 0;//获取字符串的高度

            XLeft = this.Width - (this.Width - this.FoulCalcar);
            XSize = this.Width - this.FoulCalcar * 2;
            AYUp = YUp;
            AYSize = YSize;
            temXLeft = AXLeft;
            if (this.LabelSay)//是否显示标签
            {
                ProtractLabelSay(g, this.Height - this.FoulCalcar * 3 - TitHeight);

            }
            AXLeft = XLeft;
            AXSize = XSize;
            AYUp = YUp;
            AYSize = YSize;

            if (this.Chartmark == true)
            {
                AXLeft = AXLeft + AreaXMaxWidth + Aline;
                AYUp = AYUp + AreaXMaxHeight;
                AXSize = XSize - AreaXMaxWidth * 2 - Aline * 2;
                AYSize = YSize - AreaXMaxHeight * 2;

                if (AXSize >= AYSize)
                {
                    Aleft = AXSize - AYSize;
                    AXSize = AYSize;
                }
                else
                {
                    Atop = AYSize - AXSize;
                    AYSize = AXSize;
                }
                if (Aleft != 0)
                {
                    AXLeft = AXLeft + Aleft / 2;
                }
                if (Atop != 0)
                {
                    AYUp = AYUp + Atop / 2;
                }
            }
            temXLeft = XLeft;
            float X1 = 0;
            float Y1 = 0;
            float X2 = 0;
            float Y2 = 0;
            float TX1 = 0;
            float TY1 = 0;
            float TX2 = 0;
            float TY2 = 0;
            float temf = 0;
            double radians = 0;
            temf = (this.AreaAngle * (ASum / 360) / ASum);
            TimeNum = this.AreaAngle;
            if (AXSize > 0 && AYSize > 0)
            {
                for (int i = 0; i < SzData.Length; i++)
                {
                    f = SzData[i] / ASum;
                    if (i >= WearColor.Length)
                        mybrush = new SolidBrush(WearColor[i - WearColor.Length]);
                    else
                        mybrush = new SolidBrush(WearColor[i]);
                    if (f == 0)
                        continue;
                    radians = ((double)((temf + f / 2) * 360) * Math.PI) / (double)180;
                    X1 = Convert.ToSingle(AXLeft + (AXSize / 2.0 + (int)((float)(AXSize / 2.0) * Math.Cos(radians))));
                    Y1 = Convert.ToSingle(AYUp + (AYSize / 2.0 + (int)((float)(AYSize / 2.0) * Math.Sin(radians))));

                    XMaxSize = TitG.MeasureString(AreaText[i].Trim(), LSfont);//将绘制的字符串进行格式化
                    SWidth = XMaxSize.Width;//获取字符串的宽度
                    SHeight = XMaxSize.Height;//获取字符串的高度
                    if ((temf + f / 2) * 360 > 90 && (temf + f / 2) * 360 <= 270)
                    {
                        X2 = X1 - Aline;

                        TX1 = X2 - 1 - SWidth;
                        TY1 = Y1 - SHeight / 2 - Asash;
                        TX2 = SWidth;
                        TY2 = SHeight + Asash * 2;
                        g.FillRectangle(ATbrush, TX1, TY1, TX2, TY2);//绘制内矩形
                        g.DrawRectangle(new Pen(Color.Black, 1), TX1, TY1, TX2, TY2);//绘制矩形
                        g.DrawString(AreaText[i].Trim(), LSfont, Zbrush, new PointF(X2 - SWidth + Asash - 1, Y1 - SHeight / 2));
                    }
                    else
                    {
                        X2 = X1 + Aline;

                        TX1 = X2 + 1;
                        TY1 = Y1 - SHeight / 2 - Asash;
                        TX2 = SWidth;
                        TY2 = SHeight + Asash * 2;
                        g.FillRectangle(ATbrush, TX1, TY1, TX2, TY2);//绘制内矩形
                        g.DrawRectangle(new Pen(Color.Black, 1), TX1, TY1, TX2, TY2);//绘制矩形
                        g.DrawString(AreaText[i].Trim(), LSfont, Zbrush, new PointF(X2 + Asash + 1, Y1 - SHeight / 2));
                    }
                    Y2 = Y1;

                    g.DrawLine(new Pen(new SolidBrush(Color.Black), 1), X1, Y1, X2, Y2);
                    TimeNum += f * 360;
                    temf = temf + f;
                }
            }
            else
                return;
        }
        #endregion

        #region 绘制图表
        /// <summary>
        /// 绘制图表
        /// </summary>
        /// <param Variable="int">判断图表的绘样式</param>
        private void DrawText(Graphics g)
        {
            int height = this.Height, width = this.Width;
            try
            {
                BXYColor = new SolidBrush(this.XYColor);
                int TitPlace = ProtractTitle(g);//绘制标题

                ProtractXY(g, TitPlace);
                switch (this.ChartStyle)
                {
                    case CharMode.Bar:
                        {
                            ProtractBar(g);//绘制条形图
                            break;
                        }
                    case CharMode.Line:
                    case CharMode.Mark:
                        {
                            ProtractLM(g);//绘制线形图和面形图
                            break;
                        }
                    case CharMode.Area:
                        {
                            ProtractArea(g);//绘制饼形图
                            break;
                        }
                    case CharMode.none: break;

                }
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }
        #endregion

        #region 事件
        private void ChartPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawText(e.Graphics);
        }

        private void ChartPanel_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
        #endregion

    }
}