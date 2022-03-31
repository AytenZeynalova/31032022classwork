using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022practic
{
    class User:IAccount
    {
        private string _password;
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get { return _password; } 
            set {
                if (PassWordChecker(value) == true)
                {
                    _password = value;
                }
            } }
        
        public bool PassWordChecker(string password)
        {
            if (password.Length >= 8 )
            {
                bool checkUpper = false;
                bool checkLower = false;
                bool checkDigit = false;
                foreach (var item in password)
                {
                    if(char.IsUpper(item))
                    {
                        checkUpper = true;
                    }

                    else if (char.IsLower(item))
                    {
                        checkLower = true;
                    }
                    else if (char.IsDigit(item))
                    {
                        checkDigit = true;
                    }
                    if (checkDigit && checkLower && checkUpper)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName}  email:{Email}   password:{_password}");
        }
    }
}
