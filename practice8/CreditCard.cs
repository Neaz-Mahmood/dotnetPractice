using System.Globalization;

public class CreditCard {
    public double MaxCreditLimit = 5000000.00;
    public string CardNumber { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string CVV { get; set; }
    public string CardHolderName { get; set; }

    public double AvailableCredit { get; set; }

    public double CreditLimit { get; set; }
    public CreditCard(string cardNumber, DateTime expirationDate, string cvv) {
        //check if card number is valid
        if (cardNumber.Length != 16) {
            throw new Exception("Invalid card number");
        }
        //card number should be numeric
        if (!long.TryParse(cardNumber, out long cardNumberLong)) {
            throw new Exception("Invalid card number");
        }
        CardNumber = cardNumber;
        ExpirationDate = expirationDate;
        CVV = cvv;
    }




}