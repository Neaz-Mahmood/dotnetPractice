public class BankTransfer : IPaymentProcessor
{
    public string BankAccountNumber { get; set; }

    public BankTransfer(string accountNumber)
    {
        BankAccountNumber = accountNumber;
    }

    public void ProcessPayment(double amount)
    {
        // Logic to process bank transfer
    }
}
