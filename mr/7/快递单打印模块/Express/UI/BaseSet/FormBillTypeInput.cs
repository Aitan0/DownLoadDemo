using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Express.Common;

namespace Express.UI.BaseSet
{
    public partial class FormBillTypeInput : Form
    {
        CommClass cc = new CommClass();
        FormBillType formBillType = null;

        public FormBillTypeInput()
        {
            InitializeComponent();
        }

        private void FormBillTypeInput_Load(object sender, EventArgs e)
        {
            formBillType = (FormBillType)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                txtBillTypeCode.Text = cc.BuildCode("tb_BillType", "", "BillTypeCode", "", 2);
            }
            else
            {
                txtBillTypeCode.Text = formBillType.dgvBillType.CurrentRow.Cells["BillTypeCode"].Value.ToString();
                txtBillTypeName.Text = formBillType.dgvBillType.CurrentRow.Cells["BillTypeName"].Value.ToString();
                txtBillWidth.Text = formBillType.dgvBillType.CurrentRow.Cells["BillWidth"].Value.ToString();
                txtBillHeight.Text = formBillType.dgvBillType.CurrentRow.Cells["BillHeight"].Value.ToString();
                txtBillCodeLength.Text = formBillType.dgvBillType.CurrentRow.Cells["BillCodeLength"].Value.ToString();
                txtRemark.Text = formBillType.dgvBillType.CurrentRow.Cells["Remark"].Value.ToString();
                //获取图片
                pbxBillPicture.Image = cc.GetImageByBytes(formBillType.dgvBillType.CurrentRow.Cells["BillPicture"].Value as Byte[]);
                if (formBillType.dgvBillType.CurrentRow.Cells["IsEnabled"].Value.ToString() == "1")
                {
                    rbIsEnabled1.Checked = true;
                }
                else
                {
                    rbIsEnabled0.Checked = true;
                }
            }
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            if (dlgPicture.ShowDialog() == DialogResult.OK)
            {
                pbxBillPicture.Image = Image.FromFile(dlgPicture.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBillTypeName.Text.Trim()))
            {
                MessageBox.Show("单据名称不许为空！", "软件提示");
                txtBillTypeName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtBillWidth.Text.Trim()))
            {
                MessageBox.Show("单据宽度不许为空！", "软件提示");
                txtBillWidth.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtBillHeight.Text.Trim()))
            {
                MessageBox.Show("单据高度不许为空！", "软件提示");
                txtBillHeight.Focus();
                return;
            }
            if (pbxBillPicture.Image == null)
            {
                MessageBox.Show("请选择单据图片！", "软件提示");
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = cc.AddDataGridViewRow(formBillType.dgvBillType, formBillType.bsBillType);
                dgvr.Cells["BillTypeCode"].Value = txtBillTypeCode.Text;
                dgvr.Cells["BillTypeName"].Value = txtBillTypeName.Text.Trim();
                dgvr.Cells["BillWidth"].Value = Convert.ToInt32(txtBillWidth.Text);
                dgvr.Cells["BillHeight"].Value = Convert.ToInt32(txtBillHeight.Text);
                dgvr.Cells["BillCodeLength"].Value = Convert.ToInt32(txtBillCodeLength.Text);
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                dgvr.Cells["BillPicture"].Value = cc.GetBytesByImage(pbxBillPicture.Image);
                if (rbIsEnabled1.Checked)
                {
                    dgvr.Cells["IsEnabled"].Value = "1";
                }
                else
                {
                    dgvr.Cells["IsEnabled"].Value = "0";
                }
                if (cc.Commit(formBillType.dgvBillType, formBillType.bsBillType))
                {
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        txtBillTypeCode.Text = cc.BuildCode("tb_BillType", "", "BillTypeCode", "", 2);
                        txtBillTypeName.Text = "";
                        txtBillWidth.Text = "";
                        txtBillHeight.Text = "";
                        txtRemark.Text = "";
                        pbxBillPicture.Image = null;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("保存失败","软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                DataGridViewRow dgvr = formBillType.dgvBillType.CurrentRow;
                dgvr.Cells["BillTypeName"].Value = txtBillTypeName.Text.Trim();
                dgvr.Cells["BillWidth"].Value = Convert.ToInt32(txtBillWidth.Text);
                dgvr.Cells["BillHeight"].Value = Convert.ToInt32(txtBillHeight.Text);
                dgvr.Cells["BillCodeLength"].Value = Convert.ToInt32(txtBillCodeLength.Text);
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                dgvr.Cells["BillPicture"].Value = cc.GetBytesByImage(pbxBillPicture.Image);
                if (rbIsEnabled1.Checked)
                {
                    dgvr.Cells["IsEnabled"].Value = "1";
                }
                else
                {
                    dgvr.Cells["IsEnabled"].Value = "0";
                }
                if (cc.Commit(formBillType.dgvBillType, formBillType.bsBillType))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBillWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            cc.InputInteger(e);
        }

        private void txtBillHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            cc.InputInteger(e);
        }

        private void txtBillCodeLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            cc.InputInteger(e);
        }
    }
}
