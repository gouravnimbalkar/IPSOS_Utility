using IPSOS_TestDataGenerator.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IPSOS_TestDataGenerator.Modules
{
    public class KPPanel
    {
        static string filePath = String.Concat(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "\\TestData.csv");
        string testdata;
        private static int count;
        static StringBuilder sb = new StringBuilder();

        /// <summary>
        /// This method will generate the test data based on given input in KPPanelConstants resource file.
        /// </summary>
        /// <param name="houseHold_number"></param>
        /// <param name="houseHold_members"></param>
        public void AddMemberDetails(int houseHold_number, string[] houseHold_members)
        {
            for (int h_no = 1; h_no <= houseHold_number; h_no++)
            {
                Console.WriteLine("Adding record for HousHold : " + h_no);
                Console.WriteLine("Neo_Code :" + InitializeData.Generate_NEO_CODE(h_no - 1));
                testdata = InitializeData.Generate_NEO_CODE(h_no - 1);
                AppendInCSV(testdata);
                
                int member_ID = Convert.ToInt32(houseHold_members[h_no - 1]);  //1
                for (int j = 1; j <= member_ID; j++)
                {
                    if (j == 1)
                    {
                        Console.WriteLine("Adding record for HousHold : " + h_no + " of Member :" + j);
                        for (int settings = 2; settings < 31; settings++)
                        {
                            switch (settings)
                            {
                                case 2:
                                    Console.WriteLine("First name :" + InitializeData.generate_First_Name());
                                    testdata = InitializeData.generate_First_Name();
                                    AppendInCSV(testdata);
                                    break;
                                case 3:
                                    Console.WriteLine("Last name :" + InitializeData.generate_Last_Name());
                                    testdata = InitializeData.generate_Last_Name();
                                    AppendInCSV(testdata);
                                    break;
                                case 4:
                                    Console.WriteLine("Address 1:" + InitializeData.Generate_SHIP_ADDRESS1());
                                    testdata = InitializeData.Generate_SHIP_ADDRESS1();
                                    AppendInCSV(testdata);
                                    break;
                                case 5:
                                    Console.WriteLine("City :" + InitializeData.Generate_SHIP_CITY());
                                    testdata = InitializeData.Generate_SHIP_CITY();
                                    AppendInCSV(testdata);
                                    break;
                                case 6:
                                    Console.WriteLine("State :" + InitializeData.Generate_SHIP_STATE());
                                    testdata = InitializeData.Generate_SHIP_STATE();
                                    AppendInCSV(testdata);
                                    break;
                                case 7:
                                    Console.WriteLine("ZIP :" + InitializeData.Generate_SHIP_ZIP());
                                    testdata = InitializeData.Generate_SHIP_ZIP();
                                    AppendInCSV(testdata);
                                    break;
                                case 8:
                                    Console.WriteLine("Respondent :" + InitializeData.Generate_RESPONDENT_R(j));
                                    testdata = InitializeData.Generate_RESPONDENT_R(j);
                                    AppendInCSV(testdata);
                                    break;
                                case 9:
                                    Console.WriteLine("Gender :" + InitializeData.Generate_GENDER_R());
                                    testdata = InitializeData.Generate_GENDER_R();
                                    AppendInCSV(testdata);
                                    break;
                                case 10:
                                    Console.WriteLine("Age :" + InitializeData.Generate_AGE_R(18, 99, 13, j));
                                    testdata = InitializeData.Generate_AGE_R(18, 99, 13, j);
                                    AppendInCSV(testdata);
                                    break;
                                case 11:
                                    Console.WriteLine("HISP :" + InitializeData.Generate_HISP_R());
                                    testdata = InitializeData.Generate_HISP_R();
                                    AppendInCSV(testdata);
                                    break;
                                case 12:
                                    Console.WriteLine("RACE_White :" + InitializeData.Generate_1_2());
                                    testdata = InitializeData.Generate_1_2();   /// Write Yes/No for RACE_WHITE columns
                                    AppendInCSV(testdata);
                                    break;
                                case 13:
                                    Console.WriteLine("RACE_Black :" + InitializeData.Generate_1_2());
                                    testdata = InitializeData.Generate_1_2();   /// Write Yes/No for RACE_BLACK columns
                                    AppendInCSV(testdata);
                                    break;
                                case 14:
                                    Console.WriteLine("RACE_Other :" + InitializeData.Generate_1_2());
                                    testdata = InitializeData.Generate_1_2();   /// Write Yes/No for RACE_OTHER columns
                                    AppendInCSV(testdata);
                                    break;
                                case 16:
                                    Console.WriteLine("INTERNET_HOME :" + InitializeData.Generate_1_2());
                                    testdata = InitializeData.Generate_1_2();   /// Write Yes/No for INTERNET_HOME columns
                                    AppendInCSV(testdata);
                                    break;
                                case 17:
                                    Console.WriteLine("HAVE_EMAIL_R :" + InitializeData.Generate_1_2());
                                    testdata = InitializeData.Generate_1_2();   /// Write Yes/No for HAVE_EMAIL_R columns
                                    AppendInCSV(testdata);
                                    break;
                                case 18:
                                    Console.WriteLine("EMAIL :" + InitializeData.Generate_EMAIL_R());
                                    testdata = InitializeData.Generate_EMAIL_R();
                                    AppendInCSV(testdata);
                                    break;
                                case 19:
                                    Console.WriteLine("PHONE_TYPE_LANDLINE :" + InitializeData.Generate_0_1());
                                    testdata = InitializeData.Generate_0_1();  /// Write Yes/No for PHONE_TYPE_LANDLINE columns
                                    AppendInCSV(testdata);
                                    break;
                                case 20:
                                    Console.WriteLine("PHONE_TYPE_OTHER :" + InitializeData.Generate_0_1());
                                    testdata = InitializeData.Generate_0_1();  /// Write Yes/No for PHONE_TYPE_OTHER columns
                                    AppendInCSV(testdata);
                                    break;
                                case 21:
                                    Console.WriteLine("PHONE_TYPE_CELL :" + InitializeData.Generate_0_1());
                                    testdata = InitializeData.Generate_0_1();  /// Write Yes/No for PHONE_TYPE_CELL columns
                                    AppendInCSV(testdata);
                                    break;
                                case 22:
                                    Console.WriteLine("CPOHH :" + InitializeData.Generate_0_1_2());
                                    testdata = InitializeData.Generate_0_1_2();  /// Write Yes/No for CPOHH columns
                                    AppendInCSV(testdata);
                                    break;
                                case 23:
                                    Console.WriteLine("Phone :" + InitializeData.generateContact_Phone());
                                    testdata = InitializeData.generateContact_Phone();
                                    AppendInCSV(testdata);
                                    break;
                                case 24:
                                    Console.WriteLine("Phone type :" + InitializeData.generateContact_Phone_type());
                                    testdata = InitializeData.generateContact_Phone_type();
                                    AppendInCSV(testdata);
                                    break;
                                case 25:
                                    Console.WriteLine("Confirm Contact number :" + InitializeData.confirm_ContactNumber);
                                    testdata = InitializeData.confirm_ContactNumber;
                                    AppendInCSV(testdata);
                                    break;
                                case 26:
                                    Console.WriteLine("Confirm Contact type :" + InitializeData.confirm_PhoneType);
                                    testdata = InitializeData.confirm_PhoneType;
                                    AppendInCSV(testdata);
                                    break;
                                case 28:
                                    Console.WriteLine("HH_SIZE_12UNDER :" + InitializeData.Generate_0_1());
                                    testdata = InitializeData.Generate_0_1();    /// Write 0/1 for HH_SIZE_12UNDER columns
                                    AppendInCSV(testdata);
                                    break;
                                case 29:
                                    Console.WriteLine("HH_SIZE_13TO17 :" + InitializeData.Generate_0_1());
                                    testdata = InitializeData.Generate_0_1();    /// Write 0/1 for HH_SIZE_13TO17 columns
                                    AppendInCSV(testdata);
                                    break;
                                case 30:
                                    Console.WriteLine("HH_SIZE_18OVER :" + InitializeData.Generate_1_2());
                                    testdata = InitializeData.Generate_1_2();    /// Write 0/1 for HH_SIZE_18OVER columns
                                    AppendInCSV(testdata);
                                    break;
                                default:
                                    AppendInCSV(" ");
                                    break;
                            }
                        }

                    }
                    else
                    {
                        for (int settings = 1; settings <= 10; settings++)
                        {
                            switch (settings)
                            {
                                case 1:
                                    Console.WriteLine("First Name_" + j + InitializeData.generate_First_Name());
                                    testdata = InitializeData.generate_First_Name();
                                    AppendInCSV(testdata);
                                    break;
                                case 2:
                                    Console.WriteLine("Last Name_" + j + InitializeData.generate_Last_Name());
                                    testdata = InitializeData.generate_Last_Name();
                                    AppendInCSV(testdata);
                                    break;
                                case 3:
                                    Console.WriteLine("Respondant" + j + InitializeData.Generate_RESPONDENT_R(j));
                                    testdata = InitializeData.Generate_RESPONDENT_R(j);
                                    AppendInCSV(testdata);
                                    break;
                                case 4:
                                    Console.WriteLine("Have_EMAIL" + j + InitializeData.Generate_1_2());
                                    testdata = InitializeData.Generate_1_2();
                                    AppendInCSV(testdata);
                                    break;
                                case 6:
                                    Console.WriteLine("EMAIL" + j + InitializeData.Generate_EMAIL_R());
                                    testdata = InitializeData.Generate_EMAIL_R();
                                    AppendInCSV(testdata);
                                    break;
                                case 7:
                                    Console.WriteLine("GENDER" + j + InitializeData.Generate_1_2());
                                    testdata = InitializeData.Generate_1_2();
                                    AppendInCSV(testdata);
                                    break;
                                case 8:
                                    Console.WriteLine("AGE" + j + InitializeData.Generate_AGE_R(18, 99, 13, j));
                                    testdata = InitializeData.Generate_AGE_R(18, 99, 13, j);
                                    AppendInCSV(testdata);
                                    break;
                                case 10:
                                    Console.WriteLine("CONSENT" + j + InitializeData.Generate_1_2());
                                    testdata = InitializeData.Generate_1_2();
                                    AppendInCSV(testdata);
                                    break;
                                default:
                                    AppendInCSV(" ");
                                    break;
                            }
                        }
                    }
                }
                for (int emp = member_ID + 1; emp <= 12; emp++)
                {
                    for (int settings = 1; settings <= 10; settings++)
                    {
                        AppendInCSV(" ");
                    }
                }

                for (int k = 0; k < 8; k++)
                {
                    AppendInCSV(" ");
                }

                Console.WriteLine("Recruiter ID" + InitializeData.Generate_RECRUITER_ID());
                testdata = InitializeData.Generate_RECRUITER_ID();
                AppendInCSV(testdata);

                Console.WriteLine("Recruiter MODE" + InitializeData.Generate_RECRUITMENT_MODE());
                testdata = InitializeData.Generate_RECRUITMENT_MODE();
                AppendInCSV(testdata);

                Console.WriteLine("ABS" + InitializeData.generate_ABS());
                testdata = InitializeData.generate_ABS();
                AppendInCSV(testdata);

                Console.WriteLine("WEB_TV" + InitializeData.generate_WEBTV());
                testdata = InitializeData.generate_WEBTV();
                AppendInCSV(testdata);

                Console.WriteLine("SCREENOUT" + InitializeData.Generate_1_2());
                testdata = InitializeData.Generate_1_2();
                AppendInCSV(testdata);

                for (int k = 0; k < 1; k++)
                {
                    AppendInCSV(" ");
                }

                Console.WriteLine("SIGNUPDATE" + InitializeData.generate_SIGNUPDATE());
                testdata = InitializeData.generate_SIGNUPDATE();
                AppendInCSV(testdata);

                Console.WriteLine("SCRIPT_LANGUAGE" + InitializeData.generate_scriptLanguage());
                testdata = InitializeData.generate_scriptLanguage();
                AppendInCSV(testdata);

                Console.WriteLine("INTERNET_DEVICE_COMP" + InitializeData.Generate_1_2());
                testdata = InitializeData.Generate_1_2();
                AppendInCSV(testdata);

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("INTERNET_DEVICE_COMP" + InitializeData.Generate_1_2());
                    testdata = InitializeData.Generate_1_2();
                    AppendInCSV(testdata);
                }

                for (int k = 0; k < 5; k++)
                {
                    AppendInCSV(" ");
                }

                Console.WriteLine("SAMPLE" + InitializeData.generate_sample());
                testdata = InitializeData.generate_sample();
                AppendInCSV(testdata);

                Console.WriteLine("HH_SIZE_18TO24" + InitializeData.Generate_HH_SIZE_18TO24());
                testdata = InitializeData.Generate_HH_SIZE_18TO24();
                AppendInCSV(testdata);

                Console.WriteLine("SPANISH_ATHOME" + InitializeData.Generate_SPANISH_ATHOME());
                testdata = InitializeData.Generate_SPANISH_ATHOME();
                AppendInCSV(testdata);

                Console.WriteLine("HOME_ADDRESS2" + InitializeData.Generate_SHIP_ADDRESS1());
                testdata = InitializeData.Generate_SHIP_ADDRESS1();
                AppendInCSV(testdata);

                for (int k = 0; k < 20; k++)
                {
                    AppendInCSV(" ");
                }

                Console.WriteLine("ORDER_REFERENCE_NUMBER" + InitializeData.generate_orderReferenceNumber());
                testdata = InitializeData.generate_orderReferenceNumber();
                AppendInCSV(testdata);
                AppendInCSV("\n");
            }

            CSVHandle.WriteInCSV(filePath, sb.ToString());
        }

        /// <summary>
        /// This method will append the generated test data values in String builder object. and WriteInCSV method will add those string in csv file.
        /// </summary>
        /// <param name="testdata"></param>
        public static void AppendInCSV(string testdata)
        {
            if (count < 189 && testdata != "\n")
            {
                try
                {
                    sb.Append(testdata);
                    sb.Append(",");
                    count++;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                try
                {
                    sb.Append(testdata);
                    count = 0;
                }

                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
