public class Bank {
    private List<BankAccount> accounts = new List<BankAccount>();

    private double totalBalance = 0;

    public void AddAccount(BankAccount account) {
        accounts.Add(account);
        totalBalance += account.balance;
    }   

    public void RemoveAccount(BankAccount account) {
        accounts.Remove(account);
        totalBalance -= account.balance;
    }

    public double GetTotalBalance() {
        foreach(BankAccount account in accounts) {
            totalBalance += account.balance;
        }
        return totalBalance;
    }
}