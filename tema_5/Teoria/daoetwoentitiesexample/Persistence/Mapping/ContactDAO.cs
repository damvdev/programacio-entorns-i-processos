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

        public void AddContacts(List<ContactDTO> contacts)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var contact in contacts)
                        {
                            string query = "INSERT INTO Contact (Name, Surname) VALUES (@Name, @Surname)";
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Name", contact.Name);
                                command.Parameters.AddWithValue("@Surname", contact.Surname);
                                command.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        Console.WriteLine("Tots els contactes s'han afegit correctament.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error en inserir contactes: {ex.Message}");
                    }
                }
            }
        }

        public void DeleteContact(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Contact WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<ContactDTO> GetAllContacts()
        {
            List<ContactDTO> contacts = new List<ContactDTO>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Name, Surname FROM Contact";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ContactDTO contact = new ContactDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Surname = reader.GetString(2)
                            };
                            contacts.Add(contact);
                        }
                    }
                }
            }
            return contacts;
        }

        public ContactDTO GetContactByID(int id)
        {
            ContactDTO contact = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Name, Surname FROM Contact WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contact = new ContactDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Surname = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            return contact;
        }

        public void UpdateContact(ContactDTO contact)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Contact SET Name = @Name, Surname = @Surname WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", contact.Name);
                    command.Parameters.AddWithValue("@Surname", contact.Surname);
                    command.Parameters.AddWithValue("@Id", contact.Id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
