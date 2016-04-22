using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app_VS2013
{
     public partial class first1
    {
        public uint defaultCom;
    
        public uint ComNum
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string ComState
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public uint Baudrate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int ComCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        /// <summary>
        /// 返回打开串口值
        /// </summary>
        public int OpenCom(uint ComNum, uint baudrate, uint stopbit, Enum par)
        {
            throw new System.NotImplementedException();
        }

        public int WriteData(string Data, uint ComNum)
        {
            throw new System.NotImplementedException();
        }

        public int ReadData(out string data, uint ComNum)
        {
            throw new System.NotImplementedException();
        }
    }
}
