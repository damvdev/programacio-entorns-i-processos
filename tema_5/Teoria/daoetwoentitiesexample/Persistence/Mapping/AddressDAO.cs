using daoexample.DTOs;
using daoexample.Persistence.DAO;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace daoexample.Persistence.Mapping
{
    public class AddressDAO : IAddressDAO
    {
        private readonly string _connectionString;

        public AddressDAO(string connectionString)
        {
            this._connectionString = connectionString;
        }

        // Afegir una adreça associada a un contacte
        public void AddAddress(AddressDTO address)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Address (ContactId, Street, City, PostalCode) VALUES (@ContactId, @Street, @City, @PostalCode)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ContactId", address.ContactId);
                    command.Parameters.AddWithValue("@Street", address.Street);
                    command.Parameters.AddWithValue("@City", address.City);
                    command.Parameters.AddWithValue("@PostalCode", address.PostalCode);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Obtenir totes les adreces d'un contacte
        public List<AddressDTO> GetAddressesByContactId(int contactId)
        {
            List<AddressDTO> addresses = new List<AddressDTO>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, ContactId, Street, City, PostalCode FROM Address WHERE ContactId = @ContactId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ContactId", contactId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            addresses.Add(new AddressDTO
                            {
                                Id = reader.GetInt32(0),
                                ContactId = reader.GetInt32(1),
                                Street = reader.GetString(2),
                                City = reader.GetString(3),
                                PostalCode = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return addresses;
        }

        // Actualitzar una adreça
        public void UpdateAddress(AddressDTO address)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Address SET Street = @Street, City = @City, PostalCode = @PostalCode WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", address.Id);
                    command.Parameters.AddWithValue("@Street", address.Street);
                    command.Parameters.AddWithValue("@City", address.City);
                    command.Parameters.AddWithValue("@PostalCode", address.PostalCode);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Eliminar una adreça
        public void DeleteAddress(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Address WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
