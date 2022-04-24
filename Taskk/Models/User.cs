using System;
using System.Collections.Generic;
using System.Text;

namespace Taskk.Models
{
    class User: IAccount
    {
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email, string password)
        {
            _id++;
            Id = _id;
            Email = email;
            Password = password;
        }
        public bool PasswordChecker()
        {          
                
                string lowerPass = Password.ToLower();
                if (Password.Length < 8) return true;
                
                if (Password == lowerPass) return true;

                int numCount = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (Password.Contains($"{i}")) numCount++; 
                }
                if (numCount == 0) return false;
            return true;
        }

        public string ShowInfo()
        {
            return $"User id : {Id}\nFullname : {Fullname}\nEmail : {Email}\n";
        }
    }
}
