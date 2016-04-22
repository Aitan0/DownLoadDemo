using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using houseAgency.mothedCls;

namespace houseAgency
{
    public partial class frmMain : Form
    {
        public string M_str_Power = string.Empty;
        string Power = string.Empty;
        public frmMain()
        {
            InitializeComponent();
        }

        #region  将MenuStrip控件中的信息添加到treeView控件中
        /// <summary>
        /// 读取菜单中的信息.
        /// </summary>
        /// <param name="treeV">TreeView控件</param>
        /// <param name="MenuS">MenuStrip控件</param>
        public void GetMenu(TreeView treeV, MenuStrip MenuS)
        {
            for (int i = 0; i < MenuS.Items.Count; i++) //遍历MenuStrip组件中的一级菜单项
            {
                //将一级菜单项的名称添加到TreeView组件的根节点中，并设置当前节点的子节点newNode1
                TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);
                newNode1.Tag = 0;
                //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                //判断当前菜单项中是否有二级菜单项
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)    //遍历二级菜单项
                    {
                        //将二级菜单名称添加到TreeView组件的子节点newNode1中，并设置当前节点的子节点newNode2
                        TreeNode newNode2 = newNode1.Nodes.Add(newmenu.DropDownItems[j].Text);
                        newNode2.Tag = int.Parse(newmenu.DropDownItems[j].Tag.ToString());
                        //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                    }
            }
        }
        #endregion

        #region  将StatusStrip控件中的信息添加到treeView控件中
        /// <summary>
        /// 读取菜单中的信息.
        /// </summary>
        /// <param name="treeV">TreeView控件</param>
        public void frm_show(int n)
        {
            switch (n)//通过标识调用各子窗体
            {
                case 0: break;
                case 1:
                    {
                        frmPeopleInfo fp = new frmPeopleInfo();//实例化一个frmPeopleInfo窗体
                        fp.strID = "want";//设置窗体中的公共变量
                        fp.Text = "求租人员信息";//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break; 
                    }
                case 2:
                    {
                        frmPeopleInfo fp = new frmPeopleInfo();
                        fp.strID = "lend";
                        fp.Text = "出租人员信息设置";
                        fp.ShowDialog();
                        fp.Dispose();
                        break;
                    }
                case 3:
                    {
                        frmPeopleList fp = new frmPeopleList();
                        fp.ShowDialog();
                        fp.Dispose();
                        break;
                    }
                case 4:
                    {
                        frmSelect fs = new frmSelect();
                        fs.ShowDialog();
                        fs.Dispose();
                        break;
                    }
                case 5:
                    {
                        frmStateHouse fs = new frmStateHouse();
                        fs.ShowDialog();
                        fs.Dispose();
                        break;
                    }
                case 6:
                    {
                        frmIntend fi = new frmIntend();
                        fi.ShowDialog();
                        fi.Dispose();
                        break;
                    }
                case 7:
                    {
                        frmEmploeey fe = new frmEmploeey();
                        fe.ShowDialog();
                        fe.Dispose();
                        break;
                    }
                case 8:
                    {
                        frmEmpleeyAll fe = new frmEmpleeyAll();
                        fe.ShowDialog();
                        fe.Dispose();
                        break;
                    }
                case 9:
                    {
                        frmType ft = new frmType();
                        ft.ShowDialog();
                        ft.Dispose();
                        break;
                    }
                case 10:
                    {
                        frmFloor ff = new frmFloor();
                        ff.ShowDialog();
                        ff.Dispose();
                        break;
                    }
                case 11:
                    {
                        frmSeat fs = new frmSeat();
                        fs.ShowDialog();
                        fs.Dispose();
                        break;
                    }
                case 12:
                    {
                        frmFitment ff = new frmFitment();
                        ff.ShowDialog();
                        ff.Dispose();
                        break;
                    }
                case 13:
                    {
                        frmFavor ff = new frmFavor();
                        ff.ShowDialog();
                        ff.Dispose();
                        break;
                    }
                case 14:
                    {
                        frmMothed fm = new frmMothed();
                        fm.ShowDialog();
                        fm.Dispose();
                        break;
                    }
                case 15:
                    {
                        frmMoney fm = new frmMoney();
                        fm.ShowDialog();
                        fm.Dispose();
                        break;
                    }
                case 16:
                    {
                        frmMoneyRemark fmr = new frmMoneyRemark();
                        fmr.ShowDialog();
                        fmr.Dispose();
                        break;
                    }
                case 17:
                    {
                        frmBargin fb = new frmBargin();
                        fb.ShowDialog();
                        fb.Dispose();
                        break;
                    }
                case 21:
                    {
                        //打开记事本
                        System.Diagnostics.Process.Start("notepad.exe");
                        break;
                    }
                case 22:
                    {
                        //打开计算器
                        System.Diagnostics.Process.Start("calc.exe");
                        break;
                    }
                case 23:
                    {
                        //打开WORD文档
                        System.Diagnostics.Process.Start("WINWORD.EXE");
                        break;
                    }
                case 24:
                    {
                        //打开EXCEL文件
                        System.Diagnostics.Process.Start("EXCEL.EXE");
                        break;
                    }
                case 25:
                    {
                        frmChangYouSelfPwd fcy = new frmChangYouSelfPwd();
                        fcy.M_str_Name = this.tspname.Text.ToString();
                        fcy.ShowDialog();
                        fcy.Dispose();
                        break;
                    }
                case 26:
                    {
                        if (MessageBox.Show("确认退出系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            Application.Exit();//关闭当前工程
                        break;
                    }
                case 27:
                    {
                        frmStock fs = new frmStock();
                        fs.ShowDialog();
                        fs.Dispose();
                        break;
                    }
                case 28:
                    {
                        frmRestore fr = new frmRestore();
                        fr.ShowDialog();
                        fr.Dispose();
                        break;
                    }
                case 29:
                    {
                        ClsCon con = new ClsCon();//实例化一个ClsCon公共类
                        con.ConDatabase();//连接数据库
                        //调用一个清理出租人和房源之间的垃极信息
                        //如当出租人来要出租房时可是没有给出他房源信息这时出租人信息就没有用了
                        try
                        {
                            SqlCommand cmd = new SqlCommand();//实例化一个SqlCommand类
                            cmd.Connection = con.conn;//与数据库建立关系统
                            cmd.Connection.Open();//打开数据库的连接
                            cmd.CommandText = "proc_clear";//存储过程的名
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();//执行存储过程
                            con.closeCon();//关闭数据库的连接
                            MessageBox.Show("恭喜已清除！！！");
                        }
                        catch (Exception ey)
                        {
                            MessageBox.Show(ey.Message);
                        }
                        break;
                    }
                case 30:
                    {
                        //打开帮助对话框
                        MessageBox.Show("\t你可以到明日科技网站\t\n\n\t  得到你想知道的\n\t    谢谢使用！！");
                        break;
                    }
            }
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            //在加载时读出权限和用户名信息
            //通过对字符串函数的调用
            if (M_str_Power != string.Empty)//当M_str_Power不为空时，也就是登录成功
            {
                //获取当前登录的用户名
                tspname.Text = M_str_Power.Substring(0, M_str_Power.IndexOf('@'));
                tspLoginTime.Text = DateTime.Now.ToLongTimeString();//获取当前系统时间
                Power = M_str_Power.Substring(M_str_Power.IndexOf('@') + 1);//获取当前的用户权限
                if (Power == "0")//当用户权限为0时
                {
                    this.tbEmpleey.Visible = false;//隐藏“员工信息”菜单
                }
                else
                {
                    this.tbEmpleey.Visible = true;
                }
                GetMenu(treeView1, menuStrip1);//设用自定义方法GetMenu()
            }
        }

        #region//常用工具

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        private void 记算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void eXECELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void wORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        #endregion

        #region//垃极清理
        private void tspClear_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        #endregion

        #region//退出设置
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        #endregion

        #region//调用其它窗体


       private void 朝向设置ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void 楼层设置ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       

       private void 求租人员信息ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void l出租人员信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }


       private void timer1_Tick(object sender, EventArgs e)
       {
           this.tspNowTime.Text = DateTime.Now.ToLongTimeString();
       }

       private void 出租房源设置ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmHouse fh = new frmHouse();
           fh.ShowDialog();
           fh.Dispose();
       }

       private void tsmHouseType_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void tsmseat_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void tsmZhuang_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void tsmUser_Click(object sender, EventArgs e)
       {
           frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
       }

       private void 物业类型设置ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmType ft = new frmType();
           ft.ShowDialog();
           ft.Dispose();
       }
      

       private void tsSelectHouse_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stStateHouse_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void tsmDataStock_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void tsmDataRestore_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

       

        private void tsWantHouse_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void 录入员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void 所有员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void 口令设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void 收费设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void 交费统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void smpbargin_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

      
        private void tmPeoControl_Click(object sender, EventArgs e)
        {
            frmPeopleList fp = new frmPeopleList();
            fp.ShowDialog();
        }
       #endregion

        private void 帮助文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_show(int.Parse(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            frm_show(int.Parse(e.Node.Tag.ToString()));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm_show(1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm_show(2);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frm_show(4);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frm_show(16);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frm_show(17);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            frm_show(Convert.ToInt32(e.Node.Tag.ToString()));
        }
    }
}