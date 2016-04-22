using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Auto_Screw_Control_Csharp
{
    public partial class ConfigForm : Form
    {
        public string ConfigPath;
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //保存并退出
            //保存数据到ini文件中
            SaveDataToIni();
            //设置该窗体返回值为OK，对主界面进行刷新操作
            this.DialogResult = DialogResult.OK;
            //关闭当前窗口
            this.Close();
        }
        public void SaveDataToIni()
        {
            //配置文件默认路径为当前exestartup路径下config.ini文件
            ConfigPath = Application.StartupPath;
            ConfigPath += "\\Config.ini";
            string temp = string.Empty;
            //检查文件是否存在
            //if exist，read configmessage from ini ,and then write into form_control
            // if not exist,will create the config.ini
            if (File.Exists(ConfigPath))
            {
                temp = this.CountNum.Value.ToString();
                ConfigFile.WriteIniData("General", "Count", temp, ConfigPath);
                temp = this.Com1Combo.Text;
                ConfigFile.WriteIniData("General", "Com1", temp, ConfigPath);
                temp = this.Com2Combo.Text;
                ConfigFile.WriteIniData("General", "Com2", temp, ConfigPath);
                temp = this.IcpdasComCombo.Text;
                ConfigFile.WriteIniData("General", "IcpdasCom", temp, ConfigPath);
                temp = this.Address.Value.ToString();
                ConfigFile.WriteIniData("General", "Address", temp, ConfigPath);
                temp = this.IndexNum.Value.ToString();
                ConfigFile.WriteIniData("General", "Index", temp, ConfigPath);
                temp = this.ScopeNum.Value.ToString();
                ConfigFile.WriteIniData("General", "Scope", temp, ConfigPath);
               

            }
            else
            {
                File.Create(ConfigPath);
            }

        }
        public void LoadDataFromIni()
        {
            ConfigPath = Application.StartupPath;
            ConfigPath += "\\Config.ini";
            string temp = string.Empty;
            
            if (File.Exists(ConfigPath))
            {
               temp= ConfigFile.ReadIniData("General", "Count", null, ConfigPath);
                this.CountNum.Value = Convert.ToInt16(temp);
                temp = ConfigFile.ReadIniData("General", "Com1", null, ConfigPath);
                this.Com1Combo.SelectedText = temp;
                temp = ConfigFile.ReadIniData("General", "Com2", null, ConfigPath);
                this.Com2Combo.SelectedText = temp;
                temp = ConfigFile.ReadIniData("General", "IcpdasCom", null, ConfigPath);
                this.IcpdasComCombo.SelectedText = temp;
                temp = ConfigFile.ReadIniData("General", "Address", null, ConfigPath);
                this.Address.Value = Convert.ToInt16(temp);
                temp = ConfigFile.ReadIniData("General", "Index", null, ConfigPath);
                this.IndexNum.Value = Convert.ToInt16(temp);
                temp = ConfigFile.ReadIniData("General", "Scope", null, ConfigPath);
                this.ScopeNum.Value = Convert.ToInt16(temp);

            }
            else
            {
                File.Create(ConfigPath);
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToAddRows = false;
            this.timer1.Enabled = false;
            this.timer2.Enabled = false;
            string[] portname = SerialPort.GetPortNames();
            for (int i = 0; i < portname.Length; i++)
            {
                this.Com1Combo.Items.Add(portname[i]);
                this.Com2Combo.Items.Add(portname[i]);
                this.IcpdasComCombo.Items.Add(portname[i]);
            }
            SetListView();
            LoadDataFromIni();
           

        }

        public void SetListView()
        {

            this.dataGridView1.ColumnCount = 2;
           
          //  this.dataGridView1.Columns[0].HeaderText = "序号";
          //  this.dataGridView1.Columns[0].Width = 40;
            this.dataGridView1.Columns[0].HeaderText = "最小值";
            this.dataGridView1.Columns[0].Width = 80;
            this.dataGridView1.Columns[1].HeaderText = "最大值";
            this.dataGridView1.Columns[1].Width = 80;
            this.dataGridView2.ColumnCount = 2;
         //  this.dataGridView2.Columns[0].HeaderText = "序号";
          //  this.dataGridView2.Columns[0].Width = 40;
            this.dataGridView2.Columns[0].HeaderText = "最小值";
            this.dataGridView2.Columns[0].Width = 80;
            this.dataGridView2.Columns[1].HeaderText = "最大值";
            this.dataGridView2.Columns[1].Width = 80;
      

        }

        private void CountNum_ValueChanged(object sender, EventArgs e)
        {
            int temp = 0;
            int count = (int)this.CountNum.Value;
            temp = this.dataGridView1.RowCount;
            int index = 0;

            if (temp >=count)
            {
                this.dataGridView1.RowCount = count;
                this.dataGridView2.RowCount = count;
               // for (int i = temp; i >=count; i--)
              //  {
                 //  DataGridViewRow row = dataGridView1.Rows[temp-1];
                  //  this.dataGridView1.Rows.Remove(row);
                   // this.dataGridView1.Rows.RemoveAt(temp-2);
              //  }
            }
            else
            {
                for (int j = temp; j <= count; j++)
                {
                    index = this.dataGridView1.Rows.Add();
                    index = this.dataGridView2.Rows.Add();
                  //  this.dataGridView1.Rows[index].Cells[0].Value = j;
                }
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }


    }
}
