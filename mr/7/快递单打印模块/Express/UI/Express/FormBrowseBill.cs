using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Express.Common;
using Express.DAL;
using Express.CusControl;

namespace Express.UI.Express
{
    public partial class FormBrowseBill : Form
    {
        private CTextBox ctxt = null;
        private DataOperate dataOper = new DataOperate();
        private CommClass cc = new CommClass();
        private DataTable dtBillType = null;
        FormExpressBill formExpressBill = null;
        CTextBox ctxtExpressBillCode = null;  //表示快递单号的CTextBox
        string strBillTypeCode = null;
        string strExpressBillCode = null;
        float fDpiX;
        float fDpiY;

        public FormBrowseBill()
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

        public void DrawImage(Graphics g)
        {
            //光标相对的原点是屏幕的左上角顶点；而控件相对的原点是所在窗体的左上角顶点
            //offset = new Point(this.Location.X, this.Location.Y);
            //引入图片
            Image img = cc.GetImageByBytes(dtBillType.Rows[0]["BillPicture"] as byte[]);
            //左上角顶点
            Point point = new Point(0, 0);
            //新的大小
            SizeF newSize = new SizeF(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillWidth"]), fDpiX),
                MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillHeight"]), fDpiY));
            //新的矩形
            RectangleF NewRect = new RectangleF(point, newSize);
            //原始图形的参数
            SizeF oldSize = new SizeF(img.Width, img.Height);
            //原始图形的大小
            RectangleF OldRect = new RectangleF(point, oldSize);
            //缩放图形处理
            g.DrawImage(img, NewRect, OldRect, System.Drawing.GraphicsUnit.Pixel);


            //若新图形的宽度或高度大于窗体的宽度或高度，窗体会自行调整
            if (newSize.Width > this.Width || newSize.Height > this.Height)
            {
                Size size = new Size(Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillWidth"]), fDpiX)), Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillHeight"]), fDpiY)));
                FormAutoResize(size);
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
                    ctxt.ContextMenuStrip = null;
                    ctxt.IsFlag = dr["IsFlag"].ToString();
                    ctxt.ControlId = Convert.ToInt32(dr["ControlId"]);
                    ctxt.Location = new Point(Convert.ToInt32(dr["X"]), Convert.ToInt32(dr["Y"]));
                    ctxt.Size = new Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                    ctxt.ControlName = dr["ControlName"].ToString();
                    if (ctxt.IsFlag == "1")  //若是单据号码对应的控件
                    {
                        ctxtExpressBillCode = ctxt;  //得到表示快递单号的CTextBox
                        ctxt.Font = new Font(new FontFamily("宋体"), 9, FontStyle.Bold);
                        ctxt.MaxLength = Convert.ToInt32(dtBillType.Rows[0]["BillCodeLength"]);
                    }
                    this.panelBillPictrue.Controls.Add(this.ctxt);
                }
                this.panelBillPictrue.Controls.Add(this.pbxBillPicture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
            }
        }

        public void InitText(string strBillTypeCode,string strExpressBillCode)
        {
            string strSql = "Select * From tb_BillText Where BillTypeCode = '" + strBillTypeCode + "' and ExpressBillCode = '" + strExpressBillCode + "'";
            try
            {
                DataTable dt = dataOper.GetDataTable(strSql, "tb_BillText");
                List<CTextBox> ctxts = GetCTextBoxes(this.panelBillPictrue);
                foreach (DataRow dr in dt.Rows)
                {
                  CTextBox ctxtTemp =  ctxts.Find(number => number.ControlId == Convert.ToInt32(dr["ControlId"]));
                  ctxtTemp.Text = dr["ControlText"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
            }
        }

        /// <summary>
        /// 删除窗体上的所有控件
        /// </summary>
        /// <param name="control">Control实例的引用</param>
        public void DisposeAllCTextBoxes(Control control)
        {
            //获取窗体上面控件的集合
            Control.ControlCollection controls = control.Controls;
            //获取集合中控件的数量
            int intCount = controls.Count;
            //使用for来循环
            for (int i = 0; i < intCount; i++)
            {
                //
                if (controls[i].GetType() == typeof(CTextBox))
                {
                    controls[i].Dispose();
                    i -= 1;
                    intCount -= 1;
                }
                if (controls[i].GetType() == typeof(GroupBox))
                {
                    this.DisposeAllCTextBoxes(controls[i]);
                }
            }
        }

        private float MillimetersToPixel(float fValue, float fDPI)
        {
            return (fValue / 25.4f) * fDPI;
        }

        public void FormAutoResize(Size size)
        {
            //获取原始Size
            int intOldWidth = this.Width;
            int intOldHeight = this.Height;
            //设置新的Size
            this.Width = size.Width + 50;
            this.Height = size.Height + 70;
            //设置新的Location
            this.Location = new Point(this.Location.X - (this.Width - intOldWidth) / 2, this.Location.Y - (this.Height - intOldHeight) / 2);
        }

        private void SetValueToDgvr(DataGridViewRow dgvr)
        {
            List<CTextBox> ctxts = GetCTextBoxes(this.panelBillPictrue);
            DataGridView dgv = dgvr.DataGridView;
            DataGridViewColumnCollection dgvcc = dgv.Columns;
            foreach (DataGridViewColumn dgvc in dgvcc)
            {
                dgvr.Cells[dgvc.Name].Value = ctxts.First<CTextBox>(element => element.ControlId == Convert.ToInt32(dgvc.Name)).Text.Trim();
            }
        }

        private void FormBrowseBill_Load(object sender, EventArgs e)
        {
            formExpressBill = (FormExpressBill)this.Owner;
            strBillTypeCode = formExpressBill.BillTypeCode;
            strExpressBillCode = formExpressBill.ExpressBillCode;
            fDpiX = this.CreateGraphics().DpiX;
            fDpiY = this.CreateGraphics().DpiY;
            dtBillType = dataOper.GetDataTable("Select * From tb_BillType Where BillTypeCode = '" + strBillTypeCode + "'", "tb_BillType");
            InitTemplate(strBillTypeCode);
            if (this.Tag.ToString() == "Query")  //查询
            {
                toolSave.Visible = false;
                toolPrint.Visible = false;
                this.Text = "查询条件输入";
            }
            else  //打印
            {
                toolQuery.Visible = false;
                InitText(strBillTypeCode, strExpressBillCode);
                this.Text = "单据打印";
            }
        }

        private void pbxBillPicture_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        private void toolQuery_Click(object sender, EventArgs e)
        {
            string strSql = String.Empty;
            //创建SqlParameter对象，并赋值
            SqlParameter param = new SqlParameter("@BillTypeCode", SqlDbType.VarChar);
            param.Value = strBillTypeCode;
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(param);
            //把泛型中的元素复制到数组中
            SqlParameter[] inputParameters = parameters.ToArray();
            DataTable dt = dataOper.GetDataTable("P_QueryExpressBill", inputParameters);
            List<CTextBox> ctxts = GetCTextBoxes(this.panelBillPictrue);
            foreach (CTextBox ctxtTemp in ctxts)
            {
                if (!(String.IsNullOrEmpty(ctxtTemp.Text.Trim())))
                {
                    //首先求得该种快递单的单据号集合
                    if (String.IsNullOrEmpty(strSql))
                    {

                        strSql = "[" + ctxtTemp.ControlId.ToString() + "] like '%" + ctxtTemp.Text.Trim() + "%'";

                    }
                    else
                    {

                        strSql += " and [" + ctxtTemp.ControlId.ToString() + "] like '%" + ctxtTemp.Text.Trim() + "%'";

                    }
                }
            }
            //DataTable dtFilter = dt.AsEnumerable().Where(itm => itm.Field<string>("318") == "zhd").CopyToDataTable();
            dt.DefaultView.RowFilter = strSql;
            formExpressBill.dgvExpressBill.DataSource = dt.DefaultView;
            this.Close();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            //---保存
            string strSql = null;
            List<string> strSqls = new List<string>();
            List<CTextBox> ctxts = GetCTextBoxes(this.panelBillPictrue);
            foreach (CTextBox ctxtTemp in ctxts)
            {
                if (ctxtTemp.IsFlag == "1")  //若是单据号
                {
                    if (String.IsNullOrEmpty(ctxtTemp.Text.Trim()))
                    {
                        MessageBox.Show("单据号不许为空！", "软件提示");
                        ctxtTemp.Focus();
                        return;
                    }
                    else
                    {
                        if (ctxtTemp.Text.Trim().Length != ctxtTemp.MaxLength)
                        {
                            MessageBox.Show("单据号位数不正确！", "软件提示");
                            ctxtTemp.Focus();
                            return;
                        }
                    }
                    if (strExpressBillCode != ctxtTemp.Text.Trim()) //在单据号发生修改的状态下
                    {
                        if (cc.IsExistExpressBillCode(ctxtTemp.Text.Trim(), strBillTypeCode))
                        {
                            MessageBox.Show("该单据号已经存在！", "软件提示");
                            ctxtTemp.Focus();
                            return;
                        }
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(ctxtTemp.Text.Trim()))
                    {
                        if (MessageBox.Show(ctxtTemp.ControlName + "为空，是否继续", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        {
                            ctxtTemp.Focus();
                            return;
                        }
                    }
                }
                strSql = "Update tb_BillText set ExpressBillCode = '" + ctxtExpressBillCode.Text.Trim() + "',ControlText = '" + ctxtTemp.Text.Trim() + "' Where BillTypeCode = '" + strBillTypeCode + "' and ExpressBillCode = '" + strExpressBillCode + "' and ControlId = '" + ctxtTemp.ControlId + "'";
                strSqls.Add(strSql);
            }
            if (strSqls.Count > 0)
            {
                if (dataOper.ExecDataBySqls(strSqls))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    SetValueToDgvr(formExpressBill.dgvExpressBill.CurrentRow);

                }
                else
                {
                    MessageBox.Show("保存失败!", "软件提示");
                }
            }
        }

        private void toolPrint_Click(object sender, EventArgs e)
        {
            //设置<打印文档>的边距
            Margins margin = new Margins(0, 0, 0, 0);
            pd.DefaultPageSettings.Margins = margin;
            //设置<打印文档>的纸张大小
            PaperSize pageSize = new PaperSize("快递单打印", Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillWidth"]), fDpiX)), Convert.ToInt32(MillimetersToPixel(Convert.ToInt32(dtBillType.Rows[0]["BillHeight"]), fDpiY)));
            pd.DefaultPageSettings.PaperSize = pageSize;
            pd.Print();
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
            List<CTextBox> ctxts = GetCTextBoxes(this.panelBillPictrue);
            foreach (CTextBox ctxtTemp in ctxts)
            {
                g.DrawString(ctxtTemp.Text, font, brush, ctxtTemp.Location.X, ctxtTemp.Location.Y);
            }
        }
    }
}
