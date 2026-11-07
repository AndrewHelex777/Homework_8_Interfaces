namespace Homework_8_Interfaces
{
    interface IValidator
    {
        bool Validate();
    }
    class PasswordValidator : IValidator
    {
        private string password;
        public PasswordValidator(string p)
        {
            password = p;
        }
        public bool Validate()
        {
            if (password.Length < 8)
            {
                return false;
            }
            bool hasLetter = false;
            bool hasDigit = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
                if (char.IsLetter(password[i]))
                {
                    hasLetter = true;
                }
                if (char.IsDigit(password[i]))
                {
                    hasDigit = true;
                }
            }
            return hasLetter && hasDigit;
        }
    }
    class EmailValidator : IValidator
    {
        private string email;
        public EmailValidator(string e)
        {
            email = e;
        }
        public bool Validate()
        {
            foreach (var item in email)
            {
                if (item == ' ')
                {
                    return false;
                }
            }
            string[] mailList = new string[] { "@gmail.com", "@outlook.com", "@ukr.net" };
            foreach (var item in mailList)
            {
                int index = email.IndexOf(item);
                if (index + item.Length == email.Length)
                {
                    if (email.IndexOf(item, index + 1) == -1)
                    {
                        if (index > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
    internal class Task5
    {
        static void Main(string[] args)
        {
            PasswordValidator p = new PasswordValidator("1w234f56x7H8");
            EmailValidator e = new EmailValidator("1w234f56x7H8@gmail.com");
            Console.WriteLine(p.Validate());
            Console.WriteLine(e.Validate());
        }
    }
}
