public class CreditCard
{
    private const decimal MaxLimit = 500000m;
    private const decimal DailyWithdrawalLimit = 100000m;
    private const decimal PerTransactionLimit = 20000m;
    private decimal currentBalance;
    private decimal dailyWithdrawnAmount;

    public CreditCard()
    {
        currentBalance = 0m;
        dailyWithdrawnAmount = 0m;
    }

    public bool WithdrawCash(decimal amount)
    {
        if (amount > PerTransactionLimit)
        {
            throw new InvalidOperationException("Per transaction limit exceeded.");
        }

        if (dailyWithdrawnAmount + amount > DailyWithdrawalLimit)
        {
            throw new InvalidOperationException("Daily withdrawal limit exceeded.");
        }

        if (currentBalance + amount > MaxLimit)
        {
            throw new InvalidOperationException("Credit card limit exceeded.");
        }

        dailyWithdrawnAmount += amount;
        currentBalance += amount;
        return true;
    }

    public bool PayBill(decimal amount)
    {
        if (currentBalance + amount > MaxLimit)
        {
            throw new InvalidOperationException("Credit card limit exceeded.");
        }

        currentBalance += amount;
        return true;
    }

    public decimal GetCurrentBalance()
    {
        return currentBalance;
    }

    public void ResetDailyWithdrawalLimit()
    {
        dailyWithdrawnAmount = 0m;
    }
}
