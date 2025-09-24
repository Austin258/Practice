namespace BankAccount_2
{
    public class BankAccount
    {
        private long accountNumber;
        private string holderName;
        private long balance;
        public BankAccount(long accountNumber, string holderName, long balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }
        public long AccountNumber
        {
            get { return accountNumber; }
            set { this.accountNumber = value; }
        }
        public string HolderName
        {
            get { return holderName; }
            set { this.holderName = value; }
        }
        public long Balance
        {
            get { return balance; }
            set { this.balance = value; }
        }
        public void Deposit(long amount)
        {
            balance += amount;
            Console.WriteLine("Deposit successful");
            Console.WriteLine("New balance: " + balance);
            Console.WriteLine("----------------------------------------");
        }
        public void Withdraw(long amount)
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
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(123456789, "John Doe", 1000);
            BankAccount account2 = new BankAccount(987654321, "Jane Doe", 2000);
            account.Deposit(500);
            account.Withdraw(200);
            account2.Deposit(1000);
            account2.Withdraw(500);
            Console.WriteLine("Account number: " + account.AccountNumber);
            Console.WriteLine("Holder name: " + account.HolderName);
            Console.WriteLine("Balance: " + account.Balance);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Account number: " + account2.AccountNumber);
            Console.WriteLine("Holder name: " + account2.HolderName);
            Console.WriteLine("Balance: " + account2.Balance);
        }
    }
}
