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
                Name = "Miquel",
                Surname = "Font"
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
        }
    }
}