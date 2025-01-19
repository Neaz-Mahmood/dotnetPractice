public class CreditCardPayment : IPaymentProcessor
{
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public DateTime ExpiryDate { get; set; }

    public CreditCardPayment(string cardNumber, string cardHolderName, DateTime expiryDate)
    {
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
        ExpiryDate = expiryDate;
    }

    public void ProcessPayment(double amount)
    {
        // Logic to process credit card payment
    }
}
