namespace Assignment22
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            Console.WriteLine("Enter a password:");
            string password = Console.ReadLine();

            if (IsValidPassword(password))
            {
                Console.WriteLine("Password is valid!");
            }
            else
            {
                Console.WriteLine("Password is invalid.");
            }
        }

        bool IsValidPassword(string password)
        {
            bool isValid = true;

            // Check length
            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long.");
                isValid = false;
            }

            // Check for uppercase letter
            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Password must contain at least one uppercase letter.");
                isValid = false;
            }

            // Check for number
            if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Password must contain at least one number.");
                isValid = false;
            }

            return isValid;
        }
    }
}
