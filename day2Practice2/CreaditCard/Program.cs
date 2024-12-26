using System;

class Program
{
    static void Main(string[] args)
    {
        CreditCard myCard = new CreditCard();

        try
        {
            Console.WriteLine("Attempting to withdraw 10,000...");
            myCard.WithdrawCash(10000m);
            Console.WriteLine("Withdrawal successful. Current balance: " + myCard.GetCurrentBalance());

            Console.WriteLine("Attempting to pay bill of 50,000...");
            myCard.PayBill(50000m);
            Console.WriteLine("Bill payment successful. Current balance: " + myCard.GetCurrentBalance());

            Console.WriteLine("Attempting to withdraw 25,000...");
            myCard.WithdrawCash(25000m);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Operation failed: " + ex.Message);
        }

        Console.WriteLine("Final balance: " + myCard.GetCurrentBalance());
    }
}

