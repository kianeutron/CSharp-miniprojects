namespace Assignment19
{
    class BankAccount
    {
        // Private fields
        private string AccountHolder { get; set; }
        private string AccountNumber { get; set; }
        private double Balance { get; set; }

        // Constructor to initialize account
        public BankAccount(string accountNumber, string accountHolder, double initialDeposit)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialDeposit > 0 ? initialDeposit : 0; // Avoid negative deposits
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New balance: {Balance:C}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        // Method to display account details
        public void DisplayDetails()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }
}
