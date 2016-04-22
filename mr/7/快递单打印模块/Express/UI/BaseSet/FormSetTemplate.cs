using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Express.CusControl;
using Express.DAL;
using Express.Common;

namespace Express.UI.BaseSet
{
    public partial class FormSetTemplate : Form
    {
        private FormBillType formBillType = null;
        private CTextBox ctxt = null;
        private DataGridViewRow dgvrBillType = null;
        private Point offset;
        private DataOperate dataOper = new DataOperate();
        private CommClass cc = new CommClass();
        float fDpiX;
        float fDpiY;

        public FormSetTemplate()
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
            }
            return ctxts;
        }

        public void DisposeAllCTextBoxes(Control ctrl)
        {
            Control.ControlCollection ctrls = ctrl.Controls;
            int intCount = ctrls.Count;
            for (int i = 0; i < intCount; i++)
            {
                if (ctrls[i].GetType() == typeof(CTextBox))
                {
                    ctrls[i].Dispose();
                    i -= 1;
                    intCount -= 1;
                }
                if (i >= 0)
                {
                    if (ctrls[i].GetType() == typeof(GroupBox))
                    {
                        this.DisposeAllCTextBoxes(ctrls[i]);
                    }
                }
            }
        }

        public void InitTemplate(string strBillTypeCode)
        {
            string strSql = "Select * From tb_BillTemplate Where BillTypeCode = '"+strBillTypeCode+"'";
            try
            {
                DataTable dt = dataOper.GetDataTable(strSql, "tb_BillTemplate");
                foreach (DataRow dr in dt.Rows)
                {
                    ctxt = new CTextBox();
                    ctxt.IsFlag = dr["IsFlag"].ToString();
                    ctxt.Text = dr["ControlName"].ToString();
                    ctxt.ControlId = Convert.ToInt32(dr["ControlId"]);
                    ctxt.FormParent = this;
                    ctxt.DefaultValue = dr["DefaultValue"].ToString();
                    ctxt.ControlName = dr["ControlName"].ToString();
                    ctxt.TurnControlName = dr["TurnControlName"].ToString();
                    ctxt.Location = new Point(Convert.ToInt32(dr["X"]), Convert.ToInt32(dr["Y"]));
                    ctxt.Size = new Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                    ctxt.ReadOnly = true;
                    this.Controls.Add(ctxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
            }
        }

        /// <summary>
        /// 窗体自动调整大小并居中
        /// </summary>
        /// <param name="size">窗体新的size</param>
        public void FormAutoResize(Size size)
        {
            //获取窗体原始Size
            int intOldWidth = this.Width;
            int intOldHeight = this.Height;
            //设置窗体新的Size
            this.Width = size.Width + 50;
            this.Height = size.Height + 70;
            //设置新的位置(Location)居中
            this.Location = new Point(this.Location.X - (this.Width - intOldWidth)/2, this.Location.Y - (this.Height - intOldHeight)/2);
        }

        private void FormSetTemplate_MouseMove(object sender, MouseEventArgs e)
        {
            List<CTextBox> ctxts = this.GetCTextBoxes(this);
            foreach (CTextBox ctxt in ctxts)
            {
                if (e.X == ctxt.Location.X + ctxt.Size.Width)
                {
                    ctxt.Cursor = Cursors.SizeWE;
                }
                else
                {
                    ctxt.Cursor = Cursors.SizeAll;
                }
            }
        }

        private void toolAddCTextBox_Click(object sender, EventArgs e)
        {
            ctxt = new CTextBox();
            ctxt.IsFlag = "0";  //系统默认不为单据编号对应的输入框
            ctxt.ControlId = 0; //系统默认的控件编号为零
            //ctxt.Text = "请输入名称";
            ctxt.FormParent = this;
            ctxt.Location = new Point(MousePosition.X - offset.X, MousePosition.Y - offset.Y);
            ctxt.ReadOnly = true;
            ctxt.BackColor = Color.Red;
            this.Controls.Add(ctxt);
            //---选择默认的文本
            ctxt.Focus();
            ctxt.SelectAll();
        }

        private void FormSetTemplate_Load(object sender, EventArgs e)
        {
            //获取分辨率
            fDpiX = this.CreateGraphics().DpiX;
            fDpiY = this.CreateGraphics().DpiY;
            formBillType = (FormBillType)this.Owner;
            dgvrBillType = formBillType.dgvBillType.CurrentRow;
            InitTemplate(dgvrBillType.Cells["BillTypeCode"].Value.ToString());

            ////光标相对的原点是屏幕的左上角顶点；而控件相对的原点是所在窗体的左上角顶点
            //offset = new Point(this.Location.X, this.Location.Y);
            ////引入图片
            //Image img = cc.GetImageByBytes(dgvrBillType.Cells["BillPicture"].Value as byte[]);
            ////左上角顶点
            //Point point = new Point(0, 0);
            ////新的大小
            //SizeF newSize = new SizeF(MillimetersToPixel(Convert.ToInt32(dgvrBillType.Cells["BillWidth"].Value), fDpiX), MillimetersToPixel(Convert.ToInt32(dgvrBillType.Cells["BillHeight"].Value), fDpiY));
            ////新的矩形
            //RectangleF NewRect = new RectangleF(point, newSize);
            ////原始图形的参数
            //SizeF oldSize = new SizeF(img.Width, img.Height);
            ////原始图形的大小
            //RectangleF OldRect = new RectangleF(point, oldSize);
            ////缩放图形处理

            //this.CreateGraphics().DrawImage(img, NewRect, OldRect, System.Drawing.GraphicsUnit.Pixel);
            ////若新图形的宽度或高度大于窗体的宽度或高度，窗体会自行调整
            //if (newSize.Width > this.Width || newSize.Height > this.Height)
            //{
            //    Size size = new Size(Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dgvrBillType.Cells["BillWidth"].Value), fDpiX)), Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dgvrBillType.Cells["BillHeight"].Value), fDpiY)));
            //    FormAutoResize(size);
            //}
            //MessageBox.Show("load");
        }

        private void FormSetTemplate_Paint(object sender, PaintEventArgs e)
        {

            //MessageBox.Show("Paint");

            //光标相对的原点是屏幕的左上角顶点；而控件相对的原点是所在窗体的左上角顶点
            offset = new Point(this.Location.X, this.Location.Y);
            //引入图片
            Image img = cc.GetImageByBytes(dgvrBillType.Cells["BillPicture"].Value as byte[]);
            //左上角顶点
            Point point = new Point(0, 0);
            //新的大小
            SizeF newSize = new SizeF(MillimetersToPixel(Convert.ToInt32(dgvrBillType.Cells["BillWidth"].Value), fDpiX), MillimetersToPixel(Convert.ToInt32(dgvrBillType.Cells["BillHeight"].Value), fDpiY));
            //新的矩形
            RectangleF NewRect = new RectangleF(point, newSize);
            //原始图形的参数
            SizeF oldSize = new SizeF(img.Width, img.Height);
            //原始图形的大小
            RectangleF OldRect = new RectangleF(point, oldSize);
            //缩放图形处理
            e.Graphics.DrawImage(img, NewRect, OldRect, System.Drawing.GraphicsUnit.Pixel);
            //若新图形的宽度或高度大于窗体的宽度或高度，窗体会自行调整
            if (newSize.Width > this.Width || newSize.Height > this.Height)
            {
                Size size = new Size(Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dgvrBillType.Cells["BillWidth"].Value), fDpiX)), Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dgvrBillType.Cells["BillHeight"].Value), fDpiY)));
                FormAutoResize(size);
            }
        }

        private float MillimetersToPixel(float fValue, float fDPI)
        {
            return (fValue / 25.4f) * fDPI;
        }

        private void GetResultIntoImage(ref Image img ,string strUserName,string strAddress,string strPhoneNumber)
        {
            Graphics g = Graphics.FromImage(img);
            Font f = new Font("宋体",12,GraphicsUnit.Pixel);
            Brush b = new SolidBrush(Color.Black);
            g.DrawImage(img,0,0,img.Width,img.Height);
            DataTable dt = dataOper.GetDataTable("Select * From tb_Template", "tb_Template");
            foreach (DataRow dr in dt.Rows)
            {
                g.DrawString(strUserName, f, b, Convert.ToInt32(dt.Rows[2]["X"]), Convert.ToInt32(dt.Rows[2]["Y"]));
                g.DrawString(strAddress, f, b, Convert.ToInt32(dt.Rows[0]["X"]), Convert.ToInt32(dt.Rows[0]["Y"]));
                g.DrawString(strPhoneNumber, f, b, Convert.ToInt32(dt.Rows[1]["X"]), Convert.ToInt32(dt.Rows[1]["Y"]));
            }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            //判断是否设置快递单号输入框的逻辑标记
            bool boolIsFlag = false;
            string strSql = null;
            //表示单据类型代码的字符串
            string strBillTypeCode = dgvrBillType.Cells["BillTypeCode"].Value.ToString();
            //List<T>泛型
            List<string> strSqls = new List<string>();
            List<CTextBox> ctxts = this.GetCTextBoxes(this);
            foreach (CTextBox ctxt in ctxts)
            {
                //查找被设置为快递单号的控件
                if (ctxt.IsFlag == "1")
                {
                    boolIsFlag = true;
                }
                //判断控件的新旧
                if(ctxt.ControlId == 0)  //若该控件为新添加的
                {
                    strSql = "INSERT INTO tb_BillTemplate(BillTypeCode,X,Y,Width,Height,IsFlag,ControlName,DefaultValue,TurnControlName) VALUES( '" + strBillTypeCode + "','" + ctxt.Location.X + "','" + ctxt.Location.Y + "','" + ctxt.Width + "','" + ctxt.Height + "','" + ctxt.IsFlag + "','" + ctxt.ControlName + "','"+ctxt.DefaultValue+"','"+ctxt.TurnControlName+"')";
                }
                else  //若该控件为旧的控件
                {
                    strSql = "Update tb_BillTemplate Set BillTypeCode = '" + strBillTypeCode + "',X = '" + ctxt.Location.X + "',Y='" + ctxt.Location.Y + "',Width = '" + ctxt.Width + "',Height = '" + ctxt.Height + "',IsFlag = '" + ctxt.IsFlag + "',ControlName = '" + ctxt.ControlName + "',DefaultValue = '"+ctxt.DefaultValue+"',TurnControlName = '"+ctxt.TurnControlName+"' Where ControlId = '" + ctxt.ControlId + "'";
                }
                strSqls.Add(strSql);
            }

            //判断快递单号输入框
            if (!boolIsFlag)
            {
                if (e.GetType() == typeof(FormClosingEventArgs))//若是关闭操作调用的保存处理
                {
                    ((FormClosingEventArgs)e).Cancel = true;//禁止关闭
                }
                MessageBox.Show("请设置快递单号输入框，否则程序无法保存！", "软件提示");
                return;
            }
            //判断快递单号输入框

            if (strSqls.Count > 0)
            {
                if (MessageBox.Show("确定要保存吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (dataOper.ExecDataBySqls(strSqls))
                    {
                        DisposeAllCTextBoxes(this);  //清除现有的控件布局
                        InitTemplate(strBillTypeCode);  //重新加载窗体上面的控件布局
                        MessageBox.Show("保存模板成功！", "软件提示");
                    }
                    else
                    {
                        MessageBox.Show("保存模板失败！", "软件提示");
                    }
                }
            }
            else
            {
                MessageBox.Show("未添加输入框，无需保存！", "软件提示");
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSetTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;//可以关闭
            List<CTextBox> ctxts = this.GetCTextBoxes(this);
            if (ctxts.Exists(itm => itm.BackColor == Color.Red))
            {
                if (MessageBox.Show("模板设置信息已被更新，是否保存？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    toolSave_Click(sender, e);
                }
            }
        }

        private void FormSetTemplate_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
