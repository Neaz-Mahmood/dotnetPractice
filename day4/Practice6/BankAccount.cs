using System.Numerics;

public class BankAccount {
    public string name { get; set; }
    public string accountNumber { get; set; }
    public double balance { get; set; }

    private BigInteger dailyTransactionCount = 0;

    private double dailyTransactionAmount { get; set; }

    public BankAccount(string name, string accountNumber, double balance) {
        if(string.IsNullOrEmpty(name)) {
            throw new ArgumentException("Name cannot be null or empty");
        }
        if(string.IsNullOrEmpty(accountNumber)) {
            throw new ArgumentException("Account number cannot be null or empty");
        }
        if(balance < 0) {
            throw new ArgumentException("Balance cannot be negative");
        }
        this.name = name;
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void Deposit(double amount) {
        if(amount < 0) {
            throw new ArgumentException("Amount cannot be negative");
        }
        balance += amount;
    }

    public void Withdraw(double amount) {
        if(amount < 0) {
            throw new ArgumentException("Amount cannot be negative");
        }
        if(balance < amount) {
            throw new ArgumentException("Insufficient balance");
        }
        balance -= amount;
    }

    public void Transfer(BankAccount destination, double amount) {
        if(amount < 0) {
            throw new ArgumentException("Amount cannot be negative");
        }
        if(balance < amount) {
            throw new ArgumentException("Insufficient balance");
        }
        balance -= amount;
        destination.Deposit(amount);
    }

   public void cashWithdrawal(double amount) {
        if(amount < 0) {
            throw new ArgumentException("Amount cannot be negative");
        }
        if(balance < amount) {
            throw new ArgumentException("Insufficient balance");
        }
        if(dailyTransactionCount >= 5) {
            throw new ArgumentException("Daily transaction limit exceeded");
        }
        if(dailyTransactionAmount + amount > 1000) {
            throw new ArgumentException("Daily transaction amount limit exceeded");
        }
        balance -= amount;
        dailyTransactionCount++;
        dailyTransactionAmount += amount;
    }

   
}