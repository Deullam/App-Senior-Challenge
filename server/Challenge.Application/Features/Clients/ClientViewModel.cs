using Challenge.Domain.Features.Clients;
using Challenge.Domain.Features.Contacts;
using System.ComponentModel.DataAnnotations;

namespace Challenge.Application.Features.Clients
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created_at { get; set; }

        public IList<Client> Contacts { get; set; }
    }
}
