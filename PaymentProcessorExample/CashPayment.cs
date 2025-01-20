public class CashPayment : IPaymentProcessor
{
    public string DeliveryPersonName { get; set; }
    public void ProcessPayment(double amount)
    {
        // Logic to process cash payment
    }
}