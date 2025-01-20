CreditCardPayment creditCardPayment = new CreditCardPayment("1234567890123456", "John Doe", new DateTime(2025, 12, 31));
MobileWalletPayment mobileWalletPayment = new MobileWalletPayment("john.doe@example.com");
BankTransfer bankTransfer = new BankTransfer("9876543210");
CashPayment cashPayment = new CashPayment() {DeliveryPersonName = "Jane Doe"};

PaymentService paymentService = new PaymentService();
paymentService.MakePayment(creditCardPayment, 100);
paymentService.MakePayment(mobileWalletPayment, 50);
paymentService.MakePayment(bankTransfer, 75);
paymentService.MakePayment(cashPayment, 100);

