namespace Assignment36
{
    public class Bank
    {
        // Array of BankAccount objects to store multiple accounts
        private BankAccount[] accounts;
        private int currentIndex = 0;

        // Constructor to initialize the array with the given capacity
        public Bank(int capacity)
        {
            accounts = new BankAccount[capacity];
        }

        // Method to create a new account
        public void CreateAccount(string accountHolder, double initialBalance)
        {
            if (currentIndex < accounts.Length)
            {
                accounts[currentIndex] = new BankAccount(accountHolder, initialBalance);
                currentIndex++;
                Console.WriteLine($"Account created for {accountHolder} with an initial balance of {initialBalance}.");
            }
            else
            {
                Console.WriteLine("Cannot create more accounts. Bank is at full capacity.");
            }
        }

        // Method to deposit funds into a specified account
        public void Deposit(int accountNumber, double amount)
        {
            if (accountNumber < currentIndex)
            {
                accounts[accountNumber].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Invalid account number.");
            }
        }

        // Method to withdraw funds from a specified account
        public void Withdraw(int accountNumber, double amount)
        {
            if (accountNumber < currentIndex)
            {
                accounts[accountNumber].Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Invalid account number.");
            }
        }

        // Method to display details of a specified account
        public void DisplayAccountDetails(int accountNumber)
        {
            if (accountNumber < currentIndex)
            {
                accounts[accountNumber].DisplayAccountDetails();
            }
            else
            {
                Console.WriteLine("Invalid account number.");
            }
        }
    }
}
