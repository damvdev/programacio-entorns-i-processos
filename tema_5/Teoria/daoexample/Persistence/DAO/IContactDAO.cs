using daoexample.DTOs;

namespace daoexample.Persistence.DAO
{
    public interface IContactDAO
    {
        public ContactDTO GetContactByID(int id);
        public IEnumerable<ContactDTO> GetAllContacts();
        public void AddContacts(List<ContactDTO> contacts);
        public void AddContact(ContactDTO contact);
        public void UpdateContact(ContactDTO contact);
        public void DeleteContact(int id);        
    }
}
