
namespace DependencyInversion_After
{
    public abstract class NotifierBase
    {
        public abstract void Notify(string message);
    }

    public class EmailNotifier : NotifierBase
    {
        public string EmailAddress { get; set; }
        public override void Notify(string message)
        {
            //send email here
        }
    }

    public class SMSNotifier : NotifierBase
    {
        public string MobileNumber { get; set; }
        public override void Notify(string message)
        {
            //send SMS here
        }
    }

    // now we have flipped the dependency from UserManager class. 
    // now its the responsibility of calling code to supply NotifierBase
    public class UserManager
    {
        private readonly NotifierBase _notifier;

        public UserManager(NotifierBase notifier)
        {
            _notifier = notifier;
        }

        public void CreateUser(string userid, string password, string email)
        {
            //create user here
            _notifier.Notify("User created successfully!");
        }

        public void ChangePassword(string userid, string oldpassword, string newpassword)
        {
            //change password here
            _notifier.Notify("Password changed successfully");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            NotifierBase emailNotifier = new EmailNotifier();
            
            UserManager userManager = new UserManager(emailNotifier);

            userManager.CreateUser("smasone", "2apples", "good to go!");
        }
    }
}
