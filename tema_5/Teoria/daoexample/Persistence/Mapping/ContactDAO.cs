using daoexample.DTOs;
using daoexample.Persistence.DAO;
using Microsoft.Data.SqlClient;

namespace daoexample.Persistence.Mapping
{
    public class ContactDAO : IContactDAO
    {
        private readonly string _connectionString;

        public ContactDAO(string connectionsString) {
            this._connectionString = connectionsString;
        }
        public void AddContact(ContactDTO contact)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Contact (Name, Surname) VALUES (@Name, @Surname)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", contact.Name);
                    command.Parameters.AddWithValue("@Surname", contact.Surname);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactDTO> GetAllContacts()
        {
            throw new NotImplementedException();
        }

        public ContactDTO GetContactByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateContact(ContactDTO contact)
        {
            throw new NotImplementedException();
        }
    }
}
