using Challenge.Domain.Features.Contacts;

namespace Challenge.Application.Features.Contacts
{
    public interface IContactService
    {

        long Add(Contact contact);
        bool Update(Contact contact);
        public ContactViewModel GetById(long id);
        IQueryable<Contact> GetAll();
        bool Remove(Contact contact);
    }
}
