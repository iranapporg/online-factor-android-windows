using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Factor
{
    class Account
    {
        string username, password;

        public Account(string Username,string Password)
        {
            username = Username;
            password = Password;
        }

        public bool Login()
        {
            object res;
            res = myLibrary.ExecuteRequest("username=" + username + "&password=" + myLibrary.CalculateMD5Hash(password, false), myLibrary.BaseUrl + "login.php");
            if (res.ToString().ToLower() == "true")
                return true;
            else
                return false;
        }

        public void saveLoginData()
        {
            myLibrary.setValueRegistery("login", "true");
            myLibrary.setValueRegistery("u", username);
            myLibrary.setValueRegistery("p", myLibrary.CalculateMD5Hash(password, false));
        }
    }
}