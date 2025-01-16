using System;

namespace Inventari
{
    public class Inventari
    {
        private Producte[] productes;

        public Inventari(int capacitat)
        {
            productes = new Producte[capacitat];
        }

        public void AfegirProducte(Producte producte, int posicio)
        {
            if (posicio < 0 || posicio >= productes.Length)
            {
                Console.WriteLine("Error: La posició és fora de límits.");
                return;
            }

            if (productes[posicio] != null)
            {
                Console.WriteLine("Error: Ja hi ha un producte en aquesta posició.");
                return;
            }

            productes[posicio] = producte;
            Console.WriteLine($"Producte afegit a la posició {posicio}.");
        }

        public void MostrarInventari()
        {
            for (int i = 0; i < productes.Length; i++)
            {
                if (productes[i] == null)
                {
                    Console.WriteLine($"Posició {i}: [BUIT]");
                }
                else
                {
                    Console.Write($"Posició {i}: ");
                    productes[i].MostrarInformacio();
                }
            }
        }
    }
}
