public interface ISupportProcess
{
    Ticket ticket { get; set; }
    void OpenTicket(string description);

    void UpdateTicket(int ticketId, string description);
    void CloseTicket(int ticketId);
}
