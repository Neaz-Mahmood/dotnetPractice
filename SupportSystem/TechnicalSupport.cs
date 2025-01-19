public class TechnicalSupport : ISupportProcess
{
    public void OpenTicket(string description)
    {
        Console.WriteLine($"Opening ticket for {description}");
    }

    public void UpdateTicket(int ticketId, string description)
    {
        Console.WriteLine($"Updating ticket {ticketId} with {description}");
    }

    public void CloseTicket(int ticketId)
    {
        Console.WriteLine($"Closing ticket {ticketId}");
    }
}