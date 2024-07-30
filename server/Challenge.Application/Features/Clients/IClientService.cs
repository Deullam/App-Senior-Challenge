using Challenge.Domain.Features.Clients;

namespace Challenge.Application.Features.Clients
{
    public interface IClientService
    {

        long Add(Client client);
        bool Update(Client client);
        public ClientViewModel GetById(long id);
        IQueryable<Client> GetAll();
        bool Remove(Client client);
    }
}
