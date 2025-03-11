using efusers.Data;
using efusers.Models;

namespace efusers {
    public class Program {
        public static void Main() {
            using var context = new ApplicationDbContext();
            var user = new User { Name = "Joan", Surname = "Garcia" };
            context.Users.Add(user);
            context.SaveChanges();

            var usuaris = context.Users.ToList();
            foreach (var usuari in usuaris) {
                Console.WriteLine($"ID:{ usuari.Id}, nom: {usuari.Name}, cognoms: {usuari.Surname}");
            }

        }
    }
}
