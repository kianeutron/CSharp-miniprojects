namespace Assignment4
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Start method is called from here
            new Program().Start();
        }

        // Start method now handles the main program interaction
        public void Start()
        {
            // Initialize a BankAccount instance with an initial balance
            BankAccount account = new BankAccount(1000m); // Initial balance is $1000

            bool running = true;
            while (running)
            {
                // Display the menu options
                Console.WriteLine("\n1. Deposit\n2. Withdraw\n3. Display Balance\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (validChoice)
                {
                    // Handle user inputs
                    switch (choice)
                    {
                        case 1:
                            // Deposit money
                            Console.Write("Enter amount to deposit: ");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            account.Deposit(depositAmount);
                            break;

                        case 2:
                            // Withdraw money
                            Console.Write("Enter amount to withdraw: ");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            account.Withdraw(withdrawAmount);
                            break;

                        case 3:
                            // Display balance
                            account.DisplayBalance();
                            break;

                        case 4:
                            // Exit
                            running = false;
                            Console.WriteLine("Exiting program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
