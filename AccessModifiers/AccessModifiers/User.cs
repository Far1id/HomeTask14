using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    internal class User
    {
        public User(string userName)
        {
            if (userName.Length >= 6 || userName.Length <= 25)
                this._userName = userName;

        }
        private string _userName;
        private string _password;

        public string Username { get { return _userName; } }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length >= 8 || value.Length <= 25)
                {
                    bool check1 = false;
                    bool check2 = false;
                    bool check3 = false;
                    foreach (var item in value)
                    {
                        if (char.IsDigit(item))
                            check1 = true;
                        if (char.IsUpper(item))
                            check2 = true;
                        if (char.IsLower(item))
                            check3 = true;
                    }
                    if (check1 && check2 && check3)
                        this._password = value;
                }

            }
        }
        public void GetInfo()
        {
            Console.WriteLine("Username : " + _userName + "Password :  " + _password);
        }
        public bool HasDigit(string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item)) return true;
            }
            return false;
        }
        public bool HasUpper(string str)
        {
            foreach (var item in str)
            {
                if (char.IsUpper(item)) return true;
            }
            return false;
        }
        public bool HasLower(string str)
        {
            foreach (var item in str)
            {
                if (char.IsLower(item)) return true;
            }
            return false;
        }
    }      
}
