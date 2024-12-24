var account = new BankAccount("John Doe", "02254", 0);


while (true) {
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Transfer");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");
    var input = Console.ReadLine();
    if (input == null) {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }
    var choice = int.Parse(input);
    switch (choice) {
        case 1:
            Console.Write("Enter amount to deposit: ");
            var depositInput = Console.ReadLine();
            if (string.IsNullOrEmpty(depositInput)) {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
                continue;
            }
            var depositAmount = decimal.Parse(depositInput);
            account.Deposit(depositAmount);
            Console.WriteLine($"Deposited {depositAmount}. New balance: {account.balance}");
            break;
        case 2:
            Console.Write("Enter amount to withdraw: ");
            var withdrawInput = Console.ReadLine();
            if (string.IsNullOrEmpty(withdrawInput)) {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
                continue;
            }
            var withdrawAmount = decimal.Parse(withdrawInput);
            account.Withdraw(withdrawAmount);
            Console.WriteLine($"Withdrew {withdrawAmount}. New balance: {account.balance}");
            break;
        case 3:
            Console.Write("Enter account number to transfer to: ");
            var destinationAccountNumber = Console.ReadLine();
            Console.Write("Enter amount to transfer: ");
            var transferInput = Console.ReadLine();
            if (string.IsNullOrEmpty(transferInput)) {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
                continue;
            }
            var transferAmount = decimal.Parse(transferInput);
            var destinationAccount = new BankAccount("Jane Doe", destinationAccountNumber, 0);
            account.Transfer(destinationAccount, transferAmount);
            Console.WriteLine($"Transferred {transferAmount} to {destinationAccount.name}. New balance: {account.balance}");
            break;
        case 4:
            return;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
    Console.WriteLine();
}