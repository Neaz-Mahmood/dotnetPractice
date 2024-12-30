public class Bank {
    public List<BankAccount> accounts { get; set; }

    public Bank() {
        accounts = new List<BankAccount>();
    }

    public void AddAccount(BankAccount account) {
        accounts.Add(account);
    }

    public void RemoveAccount(BankAccount account) {
        accounts.Remove(account);
    }

    public BankAccount GetAccount(string accountNumber) {
        return accounts.Find(account => account.accountNumber == accountNumber);
    }
}