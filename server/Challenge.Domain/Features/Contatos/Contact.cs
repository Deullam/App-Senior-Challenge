using Challenge.Domain.Exceptions;
using Challenge.Domain.Features.Clients;

namespace Challenge.Domain.Features.Contacts
{
    public class Contact
    {

        public int Id { get; set; }
        public Client Client { get; set; }
        public IList<string> Emails { get; set; }
        public IList<string> Phones { get; set; }

        public Contact(int id, Client client, IList<string> emails, IList<string> phones)
        {
            Id = id;
            Client = client;
            Emails = emails;
            Phones = phones;
        }

        /** Method used to verify the validations */
        public void Validate()
        {

            if (Client.Id == null || Client.Id == 0)
            {
                throw new ClientNotFoundException();
            }

        }

    }
}
