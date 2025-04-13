namespace Assignment36
{
    public class BankAccount
    {
        // Fields for account holder name and balance
        public string HolderName { get; set; }
        public double Balance { get; set; }

        // Constructor to initialize the bank account
        public BankAccount(string holderName, double initialBalance)
        {
            HolderName = holderName;
            Balance = initialBalance;
        }

        // Method to deposit funds into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New balance is {Balance}.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw funds from the account
        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance is {Balance}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Holder: {HolderName}");
            Console.WriteLine($"Account Balance: {Balance}");
        }
    }
}
