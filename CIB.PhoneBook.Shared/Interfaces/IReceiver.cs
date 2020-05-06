namespace CIB.PhoneBook.Shared.Interfaces
{
    public interface IReceiver
    {
        string Protocol { get; set; }
        string Host { get; set; }
        string Port { get; set; }
        string Ip { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string HttpVerb { get; set; }

    }
}
