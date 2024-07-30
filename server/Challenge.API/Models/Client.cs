using Challenge.Domain.Features.Contacts;

namespace client.Models;

public class Client
{
    public  int Id { get; set; }
    public  string? Name { get; set; }
    public  IList<Contact>? Contacts { get; set; }
    public  DateTime? Created_at { get; set; }
}
