using System;
using System.IO;
using System.Linq;
using System.Text;

namespace IPSOS_TestDataGenerator.Utilities
{
    public static class CSVHandle
    {
        /// <summary>
        /// This methid create a CSV file wth columns at a specific location. If file already exists, this will delte and recreate the same
        /// </summary>
        /// <param name="filePath"></param> - This parameter is used to provide file path
        /// <returns>FilePATH</returns>
        public static void CreateCSV(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);
                CreateColumns(filePath);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// This method will convert CSV file to tab spaced file by replacing , with TAB
        /// </summary>
        /// <param name="filePath"></param> - This parameter is used to provide file path
        public static void CovertCSVIntoTextFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                foreach (string test in File.ReadLines(filePath))
                {
                    String line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string text = File.ReadAllText(filePath);
                        text = text.Replace(',', '\t');
                        File.WriteAllText(String.Concat(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, Resources.TestRunConstants.testdata_filepath_tabseparated), text);

                    }
                }
            }
        }

        /// <summary>
        /// This method will write text in file
        /// </summary>
        /// <param name="filePath"></param> - The parameter is used for filepath
        /// <param name="sb"></param> - The parameter is used for text that needs to be write
        public static void WriteInCSV(string filePath, string sb)
        {
            try
            {
                File.AppendAllText(filePath, sb);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// This method write all the values into file 
        /// </summary>
        /// <param name="filePath"></param> - This parameter is used for filepath
        /// <param name="text"></param> - This parameter is used for text that need to write in file
        public static void WriteColumns(string filePath, string text)
        {
            try
            {
                File.AppendAllText(filePath, text);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// This method adds column headings in CSV file from resource file
        /// </summary>
        /// <param name="filePath">This parameter is used for filepath</param>
		public static void CreateColumns(string filePath)
        {
            try
            {
                string columns = Resources.KPPanelConstants.Column_Names;
                WriteColumns(filePath,columns);

                File.AppendAllText(filePath, "\n");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
