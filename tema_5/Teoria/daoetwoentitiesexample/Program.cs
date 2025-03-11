using daoexample.DTOs;
using daoexample.Persistence.DAO;
using daoexample.Persistence.Mapping;
using daoexample.Persistence.Utils;

namespace daoexample
{
    public class Program
    {
        public static void Main()
        {
            // Crear una instància del DAO
            IContactDAO contactDAO = new ContactDAO(SQLServerUtils.OpenConnection());
            
            // Exemple d'ús del DAO
            ContactDTO newContact = new ContactDTO
            {
                Name = "Nuria",
                Surname = "Guasch"
            };

            // Afegir un nou contacte
            try
            {
               contactDAO.AddContact(newContact);
               Console.WriteLine("Registre inserit correctament.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            


            // Inserir una llista de contactes
            List<ContactDTO> newContacts = new List<ContactDTO>
            {
                new ContactDTO { Name = "Anna", Surname = "Puig" },
                new ContactDTO { Name = "Joan", Surname = "Martí" },
                new ContactDTO { Name = "Laura", Surname = "Soler" }
            };

            try
            {
                contactDAO.AddContacts(newContacts);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en inserir la llista de contactes: {e.Message}");
            }

            // Obtenir tots els contactes
            try
            {
                IEnumerable<ContactDTO> contacts = contactDAO.GetAllContacts();
                Console.WriteLine("Llista de contactes:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"ID: {contact.Id}, Nom: {contact.Name}, Cognom: {contact.Surname}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en obtenir els contactes: {e.Message}");
            }
            // Obtenir un contacte per ID
            Console.Write("Introdueix l'ID del contacte a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int contactId))
            {
                try
                {
                    ContactDTO contact = contactDAO.GetContactByID(contactId);
                    if (contact != null)
                    {
                        Console.WriteLine($"Contacte trobat -> ID: {contact.Id}, Nom: {contact.Name}, Cognom: {contact.Surname}");
                    }
                    else
                    {
                        Console.WriteLine("No s'ha trobat cap contacte amb aquest ID.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error en obtenir el contacte: {e.Message}");
                }
            }
            else
            {
                Console.WriteLine("L'ID introduït no és vàlid.");
            }
            // Actualitzar un contacte existent
            ContactDTO updatedContact = new ContactDTO
            {
                Id = 1, // Assegura't que aquest ID existeixi a la base de dades
                Name = "Miquel",
                Surname = "García"
            };

            try
            {
                contactDAO.UpdateContact(updatedContact);
                Console.WriteLine("Registre actualitzat correctament.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en actualitzar el registre: {e.Message}");
            }
            // Eliminar un contacte
            int contactIdToDelete = 1; // Assegura't que aquest ID existeixi a la base de dades

            try
            {
                contactDAO.DeleteContact(contactIdToDelete);
                Console.WriteLine("Registre eliminat correctament.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en eliminar el registre: {e.Message}");
            }
            
            
            // Crear una instància d'AddressDAO
            AddressDAO addressDAO = new AddressDAO(SQLServerUtils.OpenConnection());

            // Afegir una adreça per a un contacte existent (exemple: contacte amb ID 2)
            AddressDTO newAddress = new AddressDTO
            {
                ContactId = 2,
                Street = "Carrer Major, 25",
                City = "Barcelona",
                PostalCode = "08001"
            };

            try
            {
                addressDAO.AddAddress(newAddress);
                Console.WriteLine("Adreça afegida correctament.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en afegir l'adreça: {e.Message}");
            }

            // Obtenir totes les adreces d'un contacte
            Console.Write("Introdueix l'ID del contacte per veure les seves adreces: ");
            if (int.TryParse(Console.ReadLine(), out contactId))
            {
                List<AddressDTO> addresses = addressDAO.GetAddressesByContactId(contactId);
                if (addresses.Count > 0)
                {
                    Console.WriteLine("Adreces trobades:");
                    foreach (var address in addresses)
                    {
                        Console.WriteLine($"ID: {address.Id}, Carrer: {address.Street}, Ciutat: {address.City}, Codi Postal: {address.PostalCode}");
                    }
                }
                else
                {
                    Console.WriteLine("Aquest contacte no té adreces registrades.");
                }
            }
        }
    }
}