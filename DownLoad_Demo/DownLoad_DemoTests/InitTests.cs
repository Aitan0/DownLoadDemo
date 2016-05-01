using Microsoft.VisualStudio.TestTools.UnitTesting;
using DownLoad_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownLoad_Demo.Tests
{
    [TestClass()]
    public class InitTests
    {
        public string expected="";

        [TestMethod()]
        public void FileCheckTest()
        {
            //  Init target = new Init();
            expected = Init.FileCheck();
            Console.WriteLine(expected);
          
            Assert.IsNotNull(expected);
        //    Console.ReadKey();
            // return target.FileCheck();
        }
    }
}