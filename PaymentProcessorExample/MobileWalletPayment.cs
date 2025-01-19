public class MobileWalletPayment : IPaymentProcessor
{
    public string MobileNo { get; set; }

    public MobileWalletPayment(string mobileNo)
    {
        MobileNo = mobileNo;
    }

    public void ProcessPayment(double amount)
    {
        // Logic to process mobile wallet payment
    }
}
