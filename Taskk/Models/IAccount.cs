using System;
using System.Collections.Generic;
using System.Text;

namespace Taskk.Models
{
    interface IAccount
    {
        public bool PasswordChecker();
        public string ShowInfo();
    }
}
