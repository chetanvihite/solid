using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_Before
{
    public class EmailNotifier
    {
        public void Notify(string email, string message)
        {
            //send email here
        }
    }

    public class UserManager
    {
        EmailNotifier notifier = new EmailNotifier();

        public void CreateUser(string userid, string password, string email)
        {
            //create user here
            notifier.Notify(email, "User created successfully!");
        }

        public void ChangePassword(string userid, string oldpassword, string newpassword, string email)
        {
            //change password here
            notifier.Notify(email, "Password changed successfully");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
