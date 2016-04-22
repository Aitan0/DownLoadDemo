using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Express.CusControl;
using Express.Common;

namespace Express.UI.BaseSet
{
    public partial class FormSetProperty : Form
    {
        FormSetTemplate formSetTemplate = null;
        CTextBox ctxtCur = null;
        CommClass cc = new CommClass();

        public FormSetProperty()
        {
            InitializeComponent();
        }

        public List<CTextBox> GetCTextBoxes(Control ctrlParent)
        {
            List<CTextBox> ctxts = new List<CTextBox>();
            foreach (Control ctrl in ctrlParent.Controls)
            {
                if (ctrl.GetType() == typeof(CTextBox))
                {
                    ctxts.Add((CTextBox)ctrl);
                }
                if (ctrl.GetType() == typeof(GroupBox))
                {
                    this.GetCTextBoxes(ctrl);
                }
            }
            return ctxts;
        }


        private void FormSetProperty_Load(object sender, EventArgs e)
        {
            formSetTemplate = (FormSetTemplate)this.Owner;
            if (this.Tag.GetType() == typeof(CTextBox))
            {
                ctxtCur = this.Tag as CTextBox;
                txtDefaultValue.Visible = true;
                txtControlName.Text = ctxtCur.ControlName;
                txtDefaultValue.Text = ctxtCur.DefaultValue;
                //设置光标跳转的数据源
                cbxTurnControlName.DataSource = GetCTextBoxes(formSetTemplate);
                cbxTurnControlName.DisplayMember = "ControlName";
                cbxTurnControlName.ValueMember = "ControlName";
                //若光标跳转不为空
                if (!String.IsNullOrEmpty(ctxtCur.TurnControlName))
                {
                    cbxTurnControlName.SelectedValue = ctxtCur.TurnControlName;
                }
                else  //若光标跳转转向为空
                {
                    cbxTurnControlName.SelectedIndex = -1;
                }
                chbIsFlag.Checked = cc.GetCheckedValue(ctxtCur.IsFlag);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtControlName.Text.Trim()))
            {
                MessageBox.Show("名称不许为空！", "软件提示");
                txtControlName.Focus();
                return;
            }
            List<CTextBox> ctxts = GetCTextBoxes(formSetTemplate);
            foreach (CTextBox ctxt in ctxts)
            {
                if (!ctxt.Equals(ctxtCur))
                {
                    if (ctxt.ControlName == txtControlName.Text.Trim())
                    {
                        MessageBox.Show("名称重复，请重新设置！", "软件提示");
                        txtControlName.Focus();
                        return;
                    }
                }
            }
            //
            ctxtCur.ControlName = txtControlName.Text.Trim();
            ctxtCur.Text = txtControlName.Text.Trim();
            //
            ctxtCur.DefaultValue = txtDefaultValue.Text.Trim();
            //
            if(cbxTurnControlName.SelectedValue!=null)
            {
                ctxtCur.TurnControlName = cbxTurnControlName.SelectedValue.ToString();
            }
            //
            ctxtCur.IsFlag = cc.GetFlagValue(chbIsFlag.CheckState);
            ctxtCur.BackColor = Color.Red;
            this.Close();
        }

        private void chbIsFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsFlag.Checked)
            {
                List<CTextBox> ctxts = GetCTextBoxes(formSetTemplate);
                foreach (CTextBox ctxt in ctxts)
                {
                    if (!ctxt.Equals(ctxtCur))
                    {
                        if (ctxt.IsFlag == "1")
                        {
                            MessageBox.Show("已存在快递单号输入框！", "软件提示");
                            chbIsFlag.Checked = false;
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
