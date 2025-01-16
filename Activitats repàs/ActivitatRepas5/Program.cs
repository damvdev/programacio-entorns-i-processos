using System;

namespace Inventari {
    public class Programa
    {
        public static void Main()
        {
            Inventari inventari = new Inventari(5);

            Console.WriteLine("Afegint productes...");
            inventari.AfegirProducte(new Producte("Llapis", 0.50m, 100), 0);
            inventari.AfegirProducte(new Producte("Quadern", 2.00m, 50), 2);

            Console.WriteLine("\nInventari:");
            inventari.MostrarInventari();
        }
    }
}

