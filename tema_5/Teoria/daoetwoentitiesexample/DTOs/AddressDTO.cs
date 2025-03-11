
namespace daoexample.DTOs
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public int ContactId { get; set; }  // Clau forana a Contact
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }
}
