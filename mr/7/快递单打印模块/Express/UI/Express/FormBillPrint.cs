using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Express.CusControl;
using Express.DAL;
using Express.Common;

namespace Express.UI.Express
{
    public partial class FormBillPrint : Form
    {
        private CTextBox ctxt = null;
        //private Point offset;
        private DataOperate dataOper = new DataOperate();
        private CommClass cc = new CommClass();
        private DataTable dtBillType = null;
        private DataTable dtBillTemplate = null;
        CTextBox ctxtExpressBillCode = null;  //表示快递单号的CTextBox
        float fDpiX;
        float fDpiY;

        public FormBillPrint()
        {
            InitializeComponent();
        }

        public List<CTextBox> GetCTextBoxes(Control control)
        {
            List<CTextBox> ctxts = new List<CTextBox>();
            foreach (Control con in control.Controls)
            {
                if (con.GetType() == typeof(CTextBox))
                {
                    ctxts.Add((CTextBox)con);
                }
                if (con.GetType() == typeof(GroupBox))
                {
                    this.GetCTextBoxes(con);
                }
                if (con.GetType() == typeof(SplitContainer))
                {
                    this.GetCTextBoxes(con);
                }
                if (con.GetType() == typeof(SplitterPanel))
                {
                    this.GetCTextBoxes(con);
                }
            }
            return ctxts;
        }

        public void DisposeAllCTextBoxes(Control control)
        {
            Control.ControlCollection controls = control.Controls;
            int intCount = controls.Count;
            for (int i = 0; i < intCount; i++)
            {
                if (controls[i].GetType() == typeof(GroupBox))
                {
                    this.DisposeAllCTextBoxes(controls[i]);
                }
                if (controls[i].GetType() == typeof(SplitContainer))
                {
                    this.DisposeAllCTextBoxes(controls[i]);
                }
                if (controls[i].GetType() == typeof(SplitterPanel))
                {
                    this.DisposeAllCTextBoxes(controls[i]);
                }
                if (controls[i].GetType() == typeof(CTextBox))
                {
                    controls[i].Dispose();
                    i -= 1;
                    intCount -= 1;
                }
            }
        }

        public void InitTemplate(DataTable dt)
        {
            List<CTextBox> ctxts = new List<CTextBox>();
            DisposeAllCTextBoxes(this);
            foreach (DataRow dr in dt.Rows)
            {
                ctxt = new CTextBox();
                ctxt.ContextMenuStrip = null;
                ctxt.ControlId = Convert.ToInt32(dr["ControlId"]);
                ctxt.IsFlag = dr["IsFlag"].ToString();
                ctxt.Location = new Point(Convert.ToInt32(dr["X"]), Convert.ToInt32(dr["Y"]));
                ctxt.Size = new Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                ctxt.ControlName = dr["ControlName"].ToString();
                ctxt.DefaultValue = dr["DefaultValue"].ToString();
                ctxt.Text = ctxt.DefaultValue;
                ctxt.TurnControlName = dr["TurnControlName"].ToString();
                if (ctxt.IsFlag == "1")  //若是单据号码对应的控件
                {
                    ctxtExpressBillCode = ctxt;  //得到表示快递单号的CTextBox
                    ctxt.Font = new Font(new FontFamily("宋体"),9,FontStyle.Bold);
                    ctxt.MaxLength = Convert.ToInt32(dtBillType.Rows[0]["BillCodeLength"]);
                    ctxt.Text = cc.BuildCode("tb_BillText", "Where ControlId = '" + ctxt.ControlId + "'", "ExpressBillCode", "", ctxt.MaxLength);
                }
                this.ctxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctxt_KeyDown);
                this.splitContainer1.Panel1.Controls.Add(this.ctxt);
                ctxts.Add(ctxt);
            }
            this.splitContainer1.Panel1.Controls.Add(this.pbxBillPicture);
            if (ctxts.Where<CTextBox>(itm => itm.IsFlag == "1").Count<CTextBox>() == 0)
            {
                toolPrint.Enabled = false;
                MessageBox.Show("当前模板未设置快递单号输入框，所以无法打印", "信息提示");
            }
            else
            {
                toolPrint.Enabled = true;
            }
        }

        private void ctxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CTextBox ctxtTurnCtrl = null;
                CTextBox ctxtCurCtrl = null;
                List<CTextBox> ctxts = GetCTextBoxes(this.splitContainer1.Panel1);
                foreach (CTextBox ctxt in ctxts)
                {
                    if (ctxt.Focused)
                    {
                        ctxtCurCtrl = ctxt;
                        break;
                    }
                }
                ctxtTurnCtrl = ctxts.Find(number => number.ControlName == ctxtCurCtrl.TurnControlName);
                if (ctxtTurnCtrl != null)
                {
                    ctxtTurnCtrl.Focus();
                }
            }
        }


        public void BuildImageData(string strBillTypeCode)
        {
            dtBillType = dataOper.GetDataTable("Select * From tb_BillType Where BillTypeCode = '" + strBillTypeCode + "'", "tb_BillType");
            dtBillTemplate = dataOper.GetDataTable("Select * From tb_BillTemplate Where BillTypeCode = '" + strBillTypeCode + "'", "tb_BillTemplate");
        }

        ///// <summary>
        ///// 缩放指定的图形
        ///// </summary>
        ///// <param name="g">绘图图面对象的引用</param>
        //public void DrawImage(Graphics g)
        //{
        //    //光标相对的原点是屏幕的左上角顶点；而控件相对的原点是所在窗体的左上角顶点
        //    //offset = new Point(this.Location.X, this.Location.Y);
        //    //引入图片
        //    Image img = cc.GetImageByBytes(dtBillType.Rows[0]["BillPicture"] as byte[]);
        //    //左上角顶点
        //    Point point = new Point(0, 0);
        //    //新的大小
        //    SizeF newSize = new SizeF(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillWidth"]), fDpiX),
        //        MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillHeight"]), fDpiY));
        //    //新的矩形
        //    RectangleF NewRect = new RectangleF(point, newSize);
        //    //原始图形的参数
        //    SizeF oldSize = new SizeF(img.Width, img.Height);
        //    //原始图形的大小
        //    RectangleF OldRect = new RectangleF(point, oldSize);
        //    //缩放图形处理
        //    g.DrawImage(img, NewRect, OldRect, System.Drawing.GraphicsUnit.Pixel);
        //    //若新图形的宽度或高度大于窗体的宽度或高度，窗体会自行调整
        //    //if (newSize.Width > this.Width || newSize.Height > this.Height)
        //    //{
        //    //    Size size = new Size(Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillWidth"]), fDpiX)), Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillHeight"]), fDpiY)));
        //    //    FormAutoResize(size);
        //    //}
        //}

        private float MillimetersToPixel(float fValue, float fDPI)
        {
            return (fValue / 25.4f) * fDPI;
        }

        //public void FormAutoResize(Size size)
        //{
        //    //获取原始Size
        //    int intOldWidth = this.Width;
        //    int intOldHeight = this.Height;
        //    //设置新的Size
        //    this.Width = size.Width + 50;
        //    this.Height = size.Height + 70;
        //    //设置新的Location
        //    this.Location = new Point(this.Location.X - (this.Width - intOldWidth) / 2, this.Location.Y - (this.Height - intOldHeight) / 2);
        //}

        private void FormBillPrint_Load(object sender, EventArgs e)
        {
            //获取系统的分辨率
            //pbxBillPicture.SendToBack();
            fDpiX = this.CreateGraphics().DpiX;
            fDpiY = this.CreateGraphics().DpiY;
            cc.ListBoxBindDataSource(lbxBillTypeCode, "BillTypeCode", "BillTypeName", "Select * From tb_BillType Where IsEnabled = '1'", "tb_BillType");
            if (lbxBillTypeCode.Items.Count > 0)
            {
                BuildImageData(lbxBillTypeCode.SelectedValue.ToString());
                InitTemplate(dtBillTemplate);
            }
            else
            {
                toolPrint.Enabled = false;
            }
        }

        private void pbxBillPicture_Paint(object sender, PaintEventArgs e)
        {
            if (lbxBillTypeCode.Items.Count > 0)
            {
                //DrawImage(e.Graphics);
                Image img = cc.GetImageByBytes(dtBillType.Rows[0]["BillPicture"] as byte[]);
                //左上角顶点
                Point point = new Point(0, 0);
                //新的大小
                SizeF newSize = new SizeF(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillWidth"]), fDpiX), MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillHeight"]), fDpiY));
                //新的矩形
                RectangleF NewRect = new RectangleF(point, newSize);
                //原始图形的参数
                SizeF oldSize = new SizeF(img.Width, img.Height);
                //原始图形的大小
                RectangleF OldRect = new RectangleF(point, oldSize);
                //缩放图形处理
                e.Graphics.DrawImage(img, NewRect, OldRect, System.Drawing.GraphicsUnit.Pixel);
            }
        }

        private void lbxBillTypeCode_DoubleClick(object sender, EventArgs e)
        {
            if (lbxBillTypeCode.Items.Count > 0)
            {
                BuildImageData(lbxBillTypeCode.SelectedValue.ToString());  //双击之后自动触发所有控件的Paint事件(包括pbxBillPicture的Paint事件——>绑定到pbxBillPicture_Paint方法)
                this.Refresh();
                InitTemplate(dtBillTemplate);
            }
        }

        private void toolPrint_Click(object sender, EventArgs e)
        {
            //---保存
            string strSql = null;
            List<string> strSqls = new List<string>();
            List<CTextBox> ctxts = GetCTextBoxes(this.splitContainer1.Panel1);
            foreach (CTextBox ctxt in ctxts)
            {
                if (ctxt.IsFlag == "1")  //若是单据号
                {
                    if (String.IsNullOrEmpty(ctxt.Text.Trim()))
                    {
                        MessageBox.Show("单据号不许为空！","软件提示");
                        ctxt.Focus();
                        return;
                    }
                    else
                    {
                        if (ctxt.Text.Trim().Length != ctxt.MaxLength)
                        {
                            MessageBox.Show("单据号位数不正确！", "软件提示");
                            ctxt.Focus();
                            return;
                        }
                    }
                    if (cc.IsExistExpressBillCode(ctxt.Text.Trim(),lbxBillTypeCode.SelectedValue.ToString()))
                    {
                        MessageBox.Show("该单据号已经存在！", "软件提示");
                        ctxt.Focus();
                        return;
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(ctxt.Text.Trim()))
                    {
                        if (MessageBox.Show(ctxt.ControlName + "为空，是否继续", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        {
                            ctxt.Focus();
                            return;
                        }
                    }
                }
                
                strSql = "INSERT INTO tb_BillText(BillTypeCode,ControlId,ExpressBillCode,ControlText) VALUES( '" +lbxBillTypeCode.SelectedValue.ToString()+"','"+ ctxt.ControlId + "','" + ctxtExpressBillCode.Text.Trim() + "','" + ctxt.Text.Trim() + "')";
                strSqls.Add(strSql);
            }
            if (strSqls.Count > 0)
            {
                if (dataOper.ExecDataBySqls(strSqls))
                {
                    //设置<打印文档>的边距
                    Margins margin = new Margins(0, 0, 0, 0);
                    pd.DefaultPageSettings.Margins = margin;
                    //设置<打印文档>的纸张大小
                    PaperSize pageSize = new PaperSize("快递单打印", Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillWidth"]), fDpiX)), Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillHeight"]), fDpiY)));
                    pd.DefaultPageSettings.PaperSize = pageSize;
                    //ppd.Document = pd;
                    //ppd.ShowDialog();
                    pd.Print();
                }
                else
                {
                    MessageBox.Show("保存失败，无法打印","软件提示");
                    return;
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //获取Graphics
            Graphics g = e.Graphics;
            //DrawImage(g);
            Font font = new Font("宋体", 12, GraphicsUnit.Pixel);
            Brush brush = new SolidBrush(Color.Black);
            List<CTextBox> ctxts = GetCTextBoxes(this.splitContainer1.Panel1);
            foreach (CTextBox ctxt in ctxts)
            {
                if (ctxt.IsFlag != "1")
                {
                    g.DrawString(ctxt.Text, font, brush, ctxt.Location.X, ctxt.Location.Y);
                }
            }
            foreach (CTextBox ctxt in ctxts)
            {
                if (ctxt.IsFlag == "1")
                {
                    ctxt.Text = cc.BuildCode("tb_BillText", "Where ControlId = '" + ctxt.ControlId + "'", "ExpressBillCode", "", ctxt.MaxLength);
                }
                else
                {
                    //判断当前控件的默认值属性是否为空！
                    if (String.IsNullOrEmpty(ctxt.DefaultValue))
                    {
                        ctxt.Text = "";
                    }
                    else
                    {
                        ctxt.Text = ctxt.DefaultValue;
                    }
                }
            }
        }

        private void pd_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            //pd.DefaultPageSettings.Landscape = true;
        }
    }
}
