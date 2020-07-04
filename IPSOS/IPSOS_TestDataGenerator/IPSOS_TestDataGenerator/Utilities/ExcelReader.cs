using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPSOS_TestDataGenerator.Objects;
using Excel = Microsoft.Office.Interop.Excel;

namespace IPSOS_TestDataGenerator.Utilities
{
    public static class ExcelReader
    {
        public static readonly string _excelPath = Resources.TestRunConstants.KPPanelexcelPath;         //Path of the Excel file which has to be read

        public static List<NeoCode> getNeoCodes()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(_excelPath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            List<NeoCode> listOfNeoCodes = new List<NeoCode>();

            try
            {
                for (int i = 2; i <= rowCount; i++)                         //iterate over the rows and columns //excel is not zero based!!
                {
                    NeoCode currentNeoCode = new NeoCode();
                    currentNeoCode.ID = long.Parse(xlRange.Cells[i, 1].Value2.ToString());
                    currentNeoCode.NCode = xlRange.Cells[i, 2].Value2.ToString();
                    listOfNeoCodes.Add(currentNeoCode);
                }
            }
            catch (Exception excelreaderex)
            {
                 Console.WriteLine("Error occured while iterating excel data. Error: " + excelreaderex.Message);
                throw excelreaderex;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            xlApp.Quit();

            return listOfNeoCodes;

        }


    }

}
