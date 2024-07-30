using Challenge.Domain.Exceptions;
using System.Xml.Serialization;
using Challenge.Domain.Features.Contacts;

namespace Challenge.Domain.Features.Clients
{
    public class Client
    {

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
        public virtual DateTime Created_at { get; set; }

     

        /** Method used to verify the validations */
        public void Validate()
        {

            if (Name == String.Empty)
            {
                throw new NameEmptyException();
            }

        }

    }
}
