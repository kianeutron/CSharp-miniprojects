namespace Assignment14
{
    class BankAccount
    {
        // Private field
        private double balance;

        // Public property with controlled getter for Balance
        public double Balance
        {
            get { return balance; }
        }

        // Property for Account Holder's name
        public string AccountHolder { get; set; }

        // Constructor to initialize account holder and balance
        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            balance = initialBalance >= 0 ? initialBalance : 0; // Ensure balance can't be negative at creation
        }

        // Method for deposit - allows adding to balance
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method for withdrawal - allows subtracting from balance
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount}. Remaining balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid amount.");
            }
        }

        // Method to display account information
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}\nBalance: {Balance}");
        }
    }
}
