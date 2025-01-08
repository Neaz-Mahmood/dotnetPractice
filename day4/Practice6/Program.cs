Bank bank1 = new Bank();

BankAccount account1 = new BankAccount("John Doe", "123456", 1000);

BankAccount account2 = new BankAccount("Jane Doe", "654321", 2000);


bank1.AddAccount(account1);

Console.WriteLine(bank1.GetTotalBalance()); // Output: 1000


