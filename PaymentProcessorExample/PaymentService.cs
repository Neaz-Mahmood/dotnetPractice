class PaymentService
{
    public void MakePayment(IPaymentProcessor paymentProcessor, double amount)
    {
        // add logic to make payment
        paymentProcessor.ProcessPayment(amount);
    }
}
