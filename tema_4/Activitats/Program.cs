using System.Globalization;
using System.Text.RegularExpressions;

namespace colleccions
{
    public class Program
    {
        public static bool IsValidPhoneNumber (string number, string pattern)
        {
            
            return Regex.IsMatch(number, pattern);
        }
        
        public static void Main()
        {
            //Ex27
            string pattern = @"^(?:\+34\s?)?6\d{2}(\s?\d{3}){2}$";
            Console.WriteLine(IsValidPhoneNumber("+34 600 123 456", pattern)); // True
            Console.WriteLine(IsValidPhoneNumber("600123456", pattern));       // True
            Console.WriteLine(IsValidPhoneNumber("600 123 456", pattern));     // True
            Console.WriteLine(IsValidPhoneNumber("60012345", pattern));        // False
            Console.WriteLine(IsValidPhoneNumber("+34 700 123 456", pattern)); // False (No comença per 6)

            //Ex31, apartat f
            var cultura = new CultureInfo("ca-ES");

            var diesSetmana = cultura.
                DateTimeFormat.DayNames
                .Skip(1)
                .Concat(cultura.DateTimeFormat.DayNames.Take(1));

            foreach (var dia in diesSetmana) {
                Console.WriteLine(dia);
            }
        }
    }
}