using gestioproductes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace gestioproductes.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }

            if (Product.ID.ToString().Length > 8) {
                ModelState.AddModelError("Product.ID","L'ID ha de tenir com a màxim 8 xifres");
                return Page();
            }
            string filePath = "products.txt";
            string productLine = $"{Product.ID},{Product.Name},{Product.Amount}";

            System.IO.File.AppendAllText(filePath, productLine + Environment.NewLine);

            return RedirectToPage("ViewProduct");
        }
    }
}
