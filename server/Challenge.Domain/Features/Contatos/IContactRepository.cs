namespace Challenge.Domain.Features.Contacts
{
    public interface IContactRepository
    {
        IQueryable<Contact> GetAll();
        Contact Add(Contact entity);
        bool Update(Contact entity);
        Contact GetById(long entityId);
        bool Remove(long entityId);
    }
}
