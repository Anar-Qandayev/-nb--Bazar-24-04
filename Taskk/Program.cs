using System;
using Taskk.Models;

namespace Taskk
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("anar@gamil.com","AP205");
            user.Fullname = "Anar Qandayev";
            Console.WriteLine(user.PasswordChecker() + "\n" + user.ShowInfo());
        }
    }
}
