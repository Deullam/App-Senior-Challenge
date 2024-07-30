namespace Challenge.Domain.Features.Clients
{
    public interface IClientRepository
    {
        IQueryable<Client> GetAll();
        Client Add(Client entity);
        bool Update(Client entity);
        Client GetById(long entityId);
        bool Remove(long entityId);
    }
}
