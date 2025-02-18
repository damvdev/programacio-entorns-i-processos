using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using gestioproductes.Models;

namespace gestioproductes.Pages
{
    public class ViewProductModel : PageModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void OnGet()
        {
            string filePath = "products.txt";
            if (System.IO.File.Exists(filePath)) 
            {
                var lines = System.IO.File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        var product = new Product
                        {
                            ID = int.Parse(parts[0]),
                            Name = parts[1],
                            Amount = int.Parse(parts[2])
                        };
                        Products.Add(product);
                    }
                }
            }
        }
    }
}
