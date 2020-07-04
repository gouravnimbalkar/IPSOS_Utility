using IPSOS_TestDataGenerator.Modules;
using IPSOS_TestDataGenerator.Utilities;
using System;
using System.IO;

namespace IPSOS_TestDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string module = Resources.TestRunConstants.Module;
            string filePath = String.Concat(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, Resources.TestRunConstants.testdata_filepath);
            // SQLOperations.insertneocode();
            
            CSVHandle.CreateCSV(filePath);

            int houseHold_number = Convert.ToInt32(Resources.KPPanelConstants.Household_Number);

            String[] houseHold_members = (Resources.KPPanelConstants.Household_Members.Split(','));

            /// This switch case will generated the test data based on module input given in TestRunConstants resouce file.
            switch (module)
            {
                case "1":
                    KPPanel kp = new KPPanel();
                    kp.AddMemberDetails(houseHold_number, houseHold_members);
                    CSVHandle.CovertCSVIntoTextFile(filePath);
                    break;

                default:
                    Console.WriteLine("Please enter valid module number");
                    break;
            }
           
            Console.ReadLine();
        }
    }
}
