using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Factor
{
    class myLibrary
    {
        public static UC.factor Currentfactor;
        public static System.Windows.Forms.Panel currentParent;
        public static FactorList factorList = new FactorList();
        //public static string BaseUrl = "http://127.0.0.1/factor/";
        public static string BaseUrl = "http://iranapp.org/factor/";
        public static List<FactorType> l1 = new List<FactorType>();
        public static string myUsername;

        public static string Number2Curreny(string sNumber)
        {
            for (int i = sNumber.Length; i >= 0; i -= 3)
            {
                if (i == sNumber.Length)
                    continue;
                sNumber = sNumber.Insert(i, ",");
            }
            if (sNumber.StartsWith(","))
                return sNumber.Remove(0, 1);
            else
                return sNumber;
        }


        public static object ExecuteRequest(string data, string url)
        {
            try
            {
                byte[] dataStream = Encoding.UTF8.GetBytes(data);
                string request = url;
                WebRequest webRequest = WebRequest.Create(request);
                webRequest.Method = "post";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = dataStream.Length;
                Stream newStream = webRequest.GetRequestStream();
                newStream.Write(dataStream, 0, dataStream.Length);
                newStream.Close();
                WebResponse webResponse = webRequest.GetResponse();
                StreamReader n = new StreamReader(webResponse.GetResponseStream());
                string res = n.ReadToEnd();
                n.Close();
                return res;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static void setValueRegistery(string key, string value)
        {
            try
            {
                Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Student");
                exampleRegistryKey.SetValue(key, value);
                exampleRegistryKey.Close();
            }catch(Exception)
            {

            }
        }

        public static string getValueRegistery(string key)
        {
            try
            {
                Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Student");
                return exampleRegistryKey.GetValue(key, "false").ToString();
            }
            catch(Exception)
            {
                return "";
            }
         }

        public static string CalculateMD5Hash(string input, bool onlyNumber)
        {
            // step 1, calculate MD5 hash from input
            string res = "";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create("MD5");
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            for (int j = 0; j < sb.Length; j++)
            {
                if (Char.IsNumber(sb[j]))
                    res += sb[j];
            }
            if (onlyNumber == true)
                return res.ToString();
            else
                return sb.ToString();
        }

        public static string getDate()
        {
            PersianCalendar date = new PersianCalendar();
            StringBuilder str1 = new StringBuilder();
            str1.Append(date.GetYear(DateTime.Now).ToString("0000"));
            str1.Append("/");
            str1.Append(date.GetMonth(DateTime.Now).ToString("00"));
            str1.Append("/");
            str1.Append(date.GetDayOfMonth(DateTime.Now).ToString("00"));
            return str1.ToString();
        }
    }
}
