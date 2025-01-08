static class ValidateCard
{
    public static bool IsValid(string cardNumber, string cardType)
    {
        if (cardType == "Visa")
        {
            return IsValidVisa(cardNumber);
        }
        else if (cardType == "MasterCard")
        {
            return IsValidMasterCard(cardNumber);
        }
        else
        {
            return false;
        }

    
        int sum = 0;
        bool isSecond = false;
        for (int i = cardNumber.Length - 1; i >= 0; i--)
        {
            int d = cardNumber[i] - '0';
            if (isSecond)
            {
                d *= 2;
            }
            sum += d / 10 + d % 10;
            isSecond = !isSecond;
        }
        return sum % 10 == 0;
    }


}