using Challenge.Domain.Features.Clients;
using System.ComponentModel.DataAnnotations;

namespace Challenge.Application.Features.Contacts
{
    public class ContactViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Client Client { get; set; }
        public IList<string> Emails { get; set; }
        public IList<string> Phones { get; set; }
    }
}
