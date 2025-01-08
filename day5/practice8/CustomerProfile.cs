public class CustomerProfile {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public CreditCard? CreditCard { get; set; }

    public CustomerProfile(string name, string email, string address, string phoneNumber) {
        Name = name;
        Email = email;
        Address = address;
        PhoneNumber = phoneNumber;
    }

    public bool isValidCard() {
        if (CreditCard == null) {
            return false;
        } else if(CreditCard.ExpirationDate < DateTime.Now) {
            return false;
        } else {
            return true;
        }
    }

    
        
}