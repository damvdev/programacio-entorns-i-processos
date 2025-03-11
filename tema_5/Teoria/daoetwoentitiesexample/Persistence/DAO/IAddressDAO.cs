
using daoexample.DTOs;

namespace daoexample.Persistence.DAO
{
    public interface IAddressDAO
    {
        public void AddAddress(AddressDTO address);
        public List<AddressDTO> GetAddressesByContactId(int contactId);
        public void UpdateAddress(AddressDTO address);
        public void DeleteAddress(int id);

    }
}
