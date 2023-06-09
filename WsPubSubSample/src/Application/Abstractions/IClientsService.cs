namespace Application.Abstractions
{
    public interface IClientsService
    {
        bool AddClient(IClient client);

        bool RemoveClient(Guid guid);

        void Reset();

        Task SendAllAsync(string message, Guid publisher);

        Task SendAsync(Guid client, string message);
    }
}