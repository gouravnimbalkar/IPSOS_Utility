using IPSOS_TestDataGenerator.Objects;
using IPSOS_TestDataGenerator.Utilities;
using System;
using System.Collections.Generic;

namespace IPSOS_TestDataGenerator
{
    public static class InitializeData
    {
        public static string confirm_ContactNumber;
        public static string confirm_PhoneType;
        public static string WEBTV_ID;
        public static string scriptLanguage_ID;
      /// <summary>
      /// This method returns a NEO CODE from Excel sheet from specific index
      /// </summary>
      /// <param name="num_NeocodeIndex"></param> - This parameter is used to retrieve the neo code from specific index
      /// <returns></returns>
        public static string Generate_NEO_CODE(int num_NeocodeIndex)
        {
            try
            {
                List<NeoCode> neocodeslist = ExcelReader.getNeoCodes();
                return neocodeslist[num_NeocodeIndex].NCode;
            }
            catch(ArgumentOutOfRangeException ex )
            {
                Console.WriteLine(ex.Message);
                return "NULL";
            }
        }
        /// <summary>
        /// This method return a First Name which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns>First Name</returns>
        public static string generate_First_Name()
        {
            String[] fname = Resources.KPPanelConstants.First_Name.Split(',');
            return fname[GetRandomNumber(fname)];
        }
        /// <summary>
        /// This method returns a Last Name which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns>Last Name</returns>
        public static string generate_Last_Name()
        {
            String[] lname = Resources.KPPanelConstants.Last_Name.Split(',');
            return lname[GetRandomNumber(lname)];
        }
        /// <summary>
        /// This method returns a Respondant value which is generated randomly from list present in resource file - KPPanelConstants
        /// <param name="member"/> - This parameter is used to identify primary or secondary member
        /// </summary>
        /// <returns>Respondant</returns>
        public static string Generate_RESPONDENT_R(int member)
        {
            String[] arr = Resources.KPPanelConstants.Generate_RESPONDENT_R_var.Split(',');
            if (member == 1)
            { 
               
                return arr[1];
            }
            else
            {   
                return arr[0];
            }
        }
        /// <summary>
        /// This method returns a Gendar value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns>Gender code</returns>
        public static string Generate_GENDER_R()
        {
            String[] arr = Resources.KPPanelConstants.Generate_GENDER_R_var.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns a  1 or 2 value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> 1 or 2</returns>
        public static string Generate_1_2()
        {
            String[] arr = Resources.KPPanelConstants.generate_1_2.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns a  0 or 1 value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> 0 or 1</returns>
        public static string Generate_0_1()
        {
            String[] arr = Resources.KPPanelConstants.generate_0_1.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns a 0 or 1 or 2 value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> 0 or 1 or 2</returns>
        public static string Generate_0_1_2()
        {
            String[] arr = Resources.KPPanelConstants.generate_0_1_2.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns an age value which is generated randomly from list present in resource file - KPPanelConstants
        /// <paramref name="adult_max"/> - This parameter is for upper limit of age for adult
        /// <paramref name="adult_min"/> - This parameter is for lower limit of age for adult
        /// <paramref name="child_min"/> - This parameter is for lower limit of age for child
        /// <paramref name="member_ID"/>- This parameter is for identifying Primary or secondary member
        /// </summary>
        /// <returns> Age </returns>
        public static string Generate_AGE_R(int adult_min, int adult_max, int child_min, int member_ID)
        {
            String arr = String.Empty;
            if (member_ID <= 2)
            {
                Random random_age = new Random();
                arr = random_age.Next(adult_min, adult_max).ToString();
                return arr;
            }
            else
            {
                if (member_ID % 2 == 1)
                {
                    Random random_age = new Random();
                    arr = random_age.Next(child_min, adult_min).ToString();
                    return arr;
                }
                else
                {
                    Random random_age = new Random();
                    arr = random_age.Next(child_min, adult_max).ToString();
                    return arr;
                }
            }
        }
        /// <summary>
        /// This method returns HISP value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> HISP </returns>
        public static string Generate_HISP_R()
        {
            String[] arr = Resources.KPPanelConstants.Generate_HISP_R_var.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns an email value which is generated randomly from combination of A-Z & 0-9
        /// </summary>
        /// <returns> An Email id</returns>
        public static string Generate_EMAIL_R()
        {
            var chars = "ABCDEFG12345666KLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string email = "UserName_" + GetRandomText(chars, 6) + "@gmail.com";
            return email;
        }
        /// <summary>
        /// This method returns Phone Number value which is generated randomly from 0-9 digits
        /// </summary>
        /// <returns> Phone Number</returns>
        public static string generateContact_Phone()
        {
            var chars = "0123456789";
            string contact = "90";
            contact += GetRandomText(chars, 8);
            confirm_ContactNumber = contact;
            return contact;
        }
        /// <summary>
        /// This method returns Phone type value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> Phone Type</returns>
        public static string generateContact_Phone_type()
        {
            String[] arr = Resources.KPPanelConstants.Generate_Contact_Phone_type_var.Split(',');
            string phoneType = arr[GetRandomNumber(arr)];
            confirm_PhoneType = phoneType;
            return phoneType;
        }
        /// <summary>
        /// This method returns Address value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> Address </returns>
        public static string Generate_SHIP_ADDRESS1()
        {
            String[] arr = Resources.KPPanelConstants.Generate_SHIP_ADDRESS1_var.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns Apartment value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> Apartement </returns>
        public static string Generate_SHIP_APT()
        {
            String[] arr = Resources.KPPanelConstants.Generate_SHIP_APT_var.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns City value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> City </returns>
        public static string Generate_SHIP_CITY()
        {
            String[] arr = Resources.KPPanelConstants.Generate_SHIP_CITY_var.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns State value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> State </returns>
        public static string Generate_SHIP_STATE()
        {
            String[] arr = Resources.KPPanelConstants.Generate_SHIP_STATE_var.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns ZIP value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> ZIP </returns>
        public static string Generate_SHIP_ZIP()
        {
            String[] arr = Resources.KPPanelConstants.Generate_SHIP_ZIP_var.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns phone nuber created by generateContact_Phone method
        /// </summary>
        /// <returns> Phone </returns>
        public static string Generate_SHIP_PHONE()
        {
            return generateContact_Phone();   
        }
        /// <summary>
        /// This method returns Phone Number value which is generated randomly from 0-9 digits
        /// </summary>
        /// <returns> Phone Number</returns>
        public static string Generate_SHIP_ALT_CONTACT_PHONE()
        {
            var chars = "01234567899876543210";
            string contact = "90";
            contact += GetRandomText(chars, 8);
            confirm_ContactNumber = contact;
            return contact;
        }
        /// <summary>
        /// This method returns ABS value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> ABS </returns>
        public static string generate_ABS()
        {
            return Resources.KPPanelConstants.generate_ABS_var;
        }
        /// <summary>
        /// This method returns WEBTV value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> WEBTV </returns>
        public static string generate_WEBTV()
        {
                String[] arr = Resources.KPPanelConstants.generate_WEBTV_var.Split(',');
                string WebTV = arr[GetRandomNumber(arr)];
                WEBTV_ID = WebTV;
                return WebTV;
        }
        /// <summary>
        /// This method returns DATE value which is generated randomly with algorithm - Today's date minus 1 month or 2 months or 3 months
        /// </summary>
        /// <returns> DATE </returns>
        public static string generate_SIGNUPDATE()
        {
            String[] arr = Resources.KPPanelConstants.generate_SIGNUPDATE_var.Split(',');
            DateTime signupdate = DateTime.Now.AddMonths(Convert.ToInt32(arr[GetRandomNumber(arr)]));
            return signupdate.Date.ToString("MM-dd-yy");
        }
        /// <summary>
        /// This method returns Script Langugage value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> Script Langugage </returns>
        public static string generate_scriptLanguage()
        {
            String[] arr = Resources.KPPanelConstants.generate_scriptLanguage_var.Split(',');
            string scriptLanguage = arr[GetRandomNumber(arr)];
            scriptLanguage_ID = scriptLanguage;
            return scriptLanguage;
        }
        /// <summary>
        /// This method returns Sample value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns> Sample </returns>
        public static string generate_sample()
        {
            String[] arr = Resources.KPPanelConstants.Generate_Sample_var.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns OrderReferenceNumber value by considering WEBTV & SCRIPT LANGUAGE VALUE
        /// </summary>
        /// <returns> OrderReferenceNumber </returns>
        public static string generate_orderReferenceNumber()
        {
            Guid referenceNumber;
            if (scriptLanguage_ID.Equals("2") && WEBTV_ID.Equals("4"))
            {
                referenceNumber = new Guid("B933C969-2A67-E311-95D3-005056A36EC6");
                return referenceNumber.ToString().ToUpper();
            }
            else if (scriptLanguage_ID.Equals("1") && WEBTV_ID.Equals("4"))
            {
                referenceNumber = new Guid("7CC1A5CB-3667-E311-95D3-005056A36EC6");
                return referenceNumber.ToString().ToUpper();
            }
            else if (scriptLanguage_ID.Equals("2") && WEBTV_ID.Equals("0"))
            {
                referenceNumber = new Guid("1764F4EE-32F7-E211-95D3-005056A36EC6");
                return referenceNumber.ToString().ToUpper();
            }
            else if (scriptLanguage_ID.Equals("1") && WEBTV_ID.Equals("0"))
            {
                referenceNumber = new Guid("47888D74-33F7-E211-95D3-005056A36EC6");
                return referenceNumber.ToString().ToUpper();
            }
            else if (scriptLanguage_ID.Equals("2") && WEBTV_ID.Equals("2"))
            {
                referenceNumber = new Guid("3F322D0F-34F7-E211-95D3-005056A36EC6");
                return referenceNumber.ToString().ToUpper();
            }
            else if (scriptLanguage_ID.Equals("1") && WEBTV_ID.Equals("2"))
            {
                referenceNumber = new Guid("A755B5C7-35F7-E211-95D3-005056A36EC6");
                return referenceNumber.ToString().ToUpper();
            }
            return "";
        }
        /// <summary>
        /// This method returns a random number from a list of numbers
        /// <paramref name="arr"/> - This parameter takes an array of string
        /// </summary>
        /// <returns>Random number</returns>
        public static int GetRandomNumber(string[] arr)
        {
            Random random = new Random();
            int randomNumber = random.Next(arr.Length);
            return randomNumber;
        }
        /// <summary>
        /// This method returns a random alphanumeric text from a A-Z and 0-9 with specific length - TextLength
        /// <paramref name="AlphaNumericText"/> - This parameter is used to store all possible chracters from which we can create a random text
        /// <paramref name="Textlength"/>- This parameter is used to generate a specific length of string
        /// </summary>
        /// <returns>Random Alphanumeric text</returns>
        public static string GetRandomText(string AlphaNumericText, int Textlength)
        {
            var chars = AlphaNumericText;
            var random = new Random();
            var stringChars = new char[Textlength];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            return finalString;
        }
        /// <summary>
        /// This method returns a SPANISH_ATHOME value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns>SPANISH_ATHOME</returns>
        public static string Generate_SPANISH_ATHOME()
        {
            String[] arr = Resources.KPPanelConstants.Generate_SPANISH_ATHOME_var.Split(',');
            return arr[GetRandomNumber(arr)];
        }
        /// <summary>
        /// This method returns a HH_SIZE_18TO24 value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns>HH_SIZE_18TO24</returns>
        public static string Generate_HH_SIZE_18TO24()
        {
            String arr = Generate_AGE_R(1, 10, 1, 3);
            return arr;
        }
        /// <summary>
        /// This method returns a RECRUITER_ID value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns>RECRUITER_ID</returns>
        public static string Generate_RECRUITER_ID()
        {
            String arr = Resources.KPPanelConstants.Generate_RECRUITER_ID_var;
            return arr;
        }
        /// <summary>
        /// This method returns a RECRUITMENT_MODE value which is generated randomly from list present in resource file - KPPanelConstants
        /// </summary>
        /// <returns>RECRUITMENT_MODE</returns>
        public static string Generate_RECRUITMENT_MODE()
        {
            String[] arr = Resources.KPPanelConstants.Generate_RECRUITMENT_MODE_var.Split(',');
            return arr[0];
        }
    }
}