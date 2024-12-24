public class BankAccount {
    public string name { get; set; }
    public string accountNumber { get; set; }
    public decimal balance { get; set; }

    public BankAccount(string name, string accountNumber, decimal balance) {
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

    public void Deposit(decimal amount) {
        if(amount < 0) {
            throw new ArgumentException("Amount cannot be negative");
        }
        balance += amount;
    }

    public void Withdraw(decimal amount) {
        if(amount < 0) {
            throw new ArgumentException("Amount cannot be negative");
        }
        if(balance < amount) {
            throw new ArgumentException("Insufficient balance");
        }
        balance -= amount;
    }

    public void Transfer(BankAccount destination, decimal amount) {
        if(amount < 0) {
            throw new ArgumentException("Amount cannot be negative");
        }
        if(balance < amount) {
            throw new ArgumentException("Insufficient balance");
        }
        balance -= amount;
        destination.Deposit(amount);
    }
   
}