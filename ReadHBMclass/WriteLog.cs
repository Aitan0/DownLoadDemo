using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel=Microsoft.Office.Interop.Excel;
using System.IO;
namespace ReadHBMclass
{
   public class WriteLog
    {
        public void WriteDataToxls(string filePath)
        {
            Excel.Range xrange= null;
            Excel.Worksheet xsheet = null;
            Excel.Application xapp= new Excel.Application();
           // filePath = "C:\\Users\\aliu2197\\Desktop\\11.txt";
            if (File.Exists(filePath))
            {

            }
            else
                File.Create(filePath);
            xapp.Visible = false;
            Excel.Workbook wbook = xapp.Workbooks.Add(true);
            xsheet = (Excel.Worksheet)xapp.ActiveSheet;
         
        }
    }
}
