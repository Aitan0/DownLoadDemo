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


namespace Auto_Screw_Control_Csharp
{
    public partial class ControlForm : Form
    {
        //this is the main code to realize the auto screwdriver control
        //and in here ,define the global variable
        //this is the global config file path
        public string ConfigPath;
        //this is the first encoder com port;
        public string Com1 = string.Empty;
        //this is the second encoder com port;
        public string Com2 = string.Empty;
        //this is the DIO model com port
        public string IcpdasCom = string.Empty;
        //this is the DIO model Address
        public string Address = string.Empty;
        //this is the total count to screw
        public int CountNum = 0;
        //this is the index of codes,and use this to select the suitable code
        public int Index = 0;
        
        public ControlForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = false;
            ConfigPath = ConfigFile.GetConfigPath();
            string temp=string.Empty;
            if(File.Exists(ConfigPath))
            {
               temp= ConfigFile.ReadIniData("General", "Count", null, ConfigPath);
                this.CountData.Text = temp;
                CountNum = Convert.ToInt16(temp);
                temp = ConfigFile.ReadIniData("General", "Com1", null, ConfigPath);
                Com1 = temp;
                temp = ConfigFile.ReadIniData("General", "Com2", null, ConfigPath);
                Com2 = temp;
                temp = ConfigFile.ReadIniData("General", "IcpdasCom", null, ConfigPath);
                IcpdasCom = temp;
                temp = ConfigFile.ReadIniData("General", "Address", null, ConfigPath);
                Address = temp;
                temp = ConfigFile.ReadIniData("General", "Index", null, ConfigPath);
                
               
                Index = Convert.ToInt16(temp);

            }
            else
            {
                MessageBox.Show("配置文件不存在，将转向配置界面！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfigForm ConForm = new ConfigForm();
                if(ConForm.ShowDialog()==DialogResult.OK)
                {
                    Form1_Load(this, null);
                }
            }
        }

        private void openConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm ConForm = new ConfigForm();
            if (ConForm.ShowDialog() == DialogResult.OK)
            {
                Form1_Load(this, null);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }
        public void SetListView()
        {
            this.PosDataView1.Columns.Add("序号", 120, HorizontalAlignment.Left);
            this.PosDataView1.Columns.Add("最小值", 120, HorizontalAlignment.Left);
            this.PosDataView1.Columns.Add("最大值", 120, HorizontalAlignment.Left);
            this.PosDataView1.BeginUpdate();
            this.PosDataView2.Columns.Add("序号", 120, HorizontalAlignment.Left);
            this.PosDataView2.Columns.Add("最小值", 120, HorizontalAlignment.Left);
            this.PosDataView2.Columns.Add("最大值", 120, HorizontalAlignment.Left);
            this.PosDataView2.BeginUpdate();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
