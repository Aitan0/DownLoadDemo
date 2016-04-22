using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TsetClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string file = "C:\\11.xls";
            ReadHBMclass.ReadHBM t1 = new ReadHBMclass.ReadHBM();
            string error;
            string IP = "172.20.64.100";
            t1.Init(out error);
            t1.ConnectFromIP(IP,out error);
           t1.PrepareContinuousMeasurement(2400,0,out error);
            t1.RunContinuousMeasurement(1000,1,out error);
            t1.ExitMeasure(out error);
        }
    }
}
