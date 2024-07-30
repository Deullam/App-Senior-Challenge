using Challenge.Domain.Features.Clients;

namespace contact.Models;

public class Contact
{
    public int Id { get; set; }
    public Client Client { get; set; }
    public IList<string>? Emails { get; set; }
    public IList<string>? Phones { get; set; }
}
