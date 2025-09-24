namespace BankAccount
{
    public class BankAccount
    {
        private long accountNumber;
        private long balance;
        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public long Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(long amount)
        {
            balance += amount;
            Console.WriteLine("Deposit successful");
            Console.WriteLine("New balance: " + balance);
            Console.WriteLine("----------------------------------------");
        }
        public virtual void Withdraw(long amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful");
                Console.WriteLine("New balance: " + balance);
                Console.WriteLine("----------------------------------------");
            }
        }
    }
    public class SavingsAccount : BankAccount
    {
        private double interestRate;
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        public void AddInterest()
        {
            Balance += (long)(Balance * interestRate) / 100;
            Console.WriteLine("Interest added");
            Console.WriteLine("New balance: " + Balance);
            Console.WriteLine("----------------------------------------");
        }
    }
    public class CurrentAccount : BankAccount
    {
        private long overdraftLimit;
        public long OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }
        public override void Withdraw(long amount)
        {
            if (amount > Balance + overdraftLimit)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful");
                Console.WriteLine("New balance: " + Balance);
                Console.WriteLine("----------------------------------------");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.AccountNumber = 123456789;
            savingsAccount.Balance = 1000;
            savingsAccount.InterestRate = 5;
            savingsAccount.Deposit(500);
            savingsAccount.Withdraw(200);
            savingsAccount.AddInterest();
            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.AccountNumber = 987654321;
            currentAccount.Balance = 2000;
            currentAccount.OverdraftLimit = 1000;
            currentAccount.Deposit(1000);
            currentAccount.Withdraw(500);
            currentAccount.Withdraw(3000);
            Console.WriteLine("Account number: " + savingsAccount.AccountNumber);
            Console.WriteLine("Balance: " + savingsAccount.Balance);
            Console.WriteLine("Interest rate: " + savingsAccount.InterestRate);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Account number: " + currentAccount.AccountNumber);
            Console.WriteLine("Balance: " + currentAccount.Balance);
            Console.WriteLine("Overdraft limit: " + currentAccount.OverdraftLimit);
            Console.WriteLine("----------------------------------------");
        }
    }
}
