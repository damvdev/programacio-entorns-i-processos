using System.ComponentModel.DataAnnotations;

namespace gestioproductes.Models
{
    public class Product
    {
        [Required(ErrorMessage = "L'ID és obligatori")]
        [Range(1,9999999, ErrorMessage = "L'ID ha de tenir 8 xifres com a màxim.")]
        public int ID { get; set; }
        [Required(ErrorMessage = "La quantitat és obligatòria")]
        [Range(1, 9999999, ErrorMessage = "La quantitat ha de tenir 8 xifres com a màxim.")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "El nom és obligatori")]
        [StringLength(100,ErrorMessage = "El nom no pot tenir més de 100 caràcters.")]
        public string? Name { get; set; }
    }
}
