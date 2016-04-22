using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test_sendsecurity
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            byte[] test=new byte[]{6,103,5,126,248,84,218,255};
            string tes=string.Empty;

        //  tes = BitConverter.ToString(test, 0, 8);
            tes = System.Text.Encoding.GetEncoding(28591).GetString(test,0,8);
            Console.WriteLine(tes.Length);
            Console.WriteLine(tes);
            sendsecuritry(tes, 3);
           
        }
        public void sendsecuritry(string message, int index)
        {
            string temp;
            Int64 sh, sl, ss;
            Int64 pin = 2271560481;
            byte[] tem = new byte[4];
            byte[] tem2 = new byte[4];
            temp = message.Substring(3,4);
       
            tem = System.Text.Encoding.GetEncoding(28591).GetBytes(temp);
         
            sh = tem[0] * 256 + tem[1];
     
            sl = tem[2] * 256 + tem[3];
        
            sh = sh * 36125 + 12343;
            sl = sl * 32125 + 12343;
            ss = sh ^ sl ^pin;
          
            tem2[0] = (byte)(ss / (256 * 256 * 256));
            tem2[1] = (byte)((ss %(256 * 256 * 256)) / (256 * 256));
            tem2[2] = (byte)((ss % (256 * 256) / 256));
            tem2[3] = (byte)(ss %256);
        
        }
    }
}
