namespace Lett2Go.EmailMngr.Interfaces
{
    public interface IEmailManager
    {
        void SendMessage(string messageText);
        void SendErrorMessage(string messageText);

    }
}
