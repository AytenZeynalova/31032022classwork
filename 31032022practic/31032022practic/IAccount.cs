using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022practic
{
    interface IAccount
    {
        bool PassWordChecker(string password);
        void ShowInfo();
    }
}
