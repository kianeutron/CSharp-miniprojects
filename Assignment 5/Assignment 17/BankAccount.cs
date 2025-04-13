namespace Assignment17
{
    class BankAccount
    {
        // Private fields
        private double balance;

        // Constructor to initialize the balance
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // Public method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                AddDeposit(amount);
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Amount must be greater than zero.");
            }
        }

        // Public method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                SubtractWithdrawal(amount);
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Console.WriteLine("Amount must be greater than zero.");
            }
        }

        // Public method to display balance
        public void DisplayBalance()
        {
            Console.WriteLine($"Current balance: {balance}");
        }

        // Private method to handle deposit addition
        private void AddDeposit(double amount)
        {
            balance += amount;
        }

        // Private method to handle withdrawal subtraction
        private void SubtractWithdrawal(double amount)
        {
            balance -= amount;
        }
    }
}
