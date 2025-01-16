using System;

namespace Inventari
{
    public class Producte
    {
        public string Nom { get; set; }
        public decimal Preu { get; set; }
        public int Quantitat { get; set; }

        public Producte(string nom, decimal preu, int quantitat)
        {
            Nom = nom;
            Preu = preu;
            Quantitat = quantitat;
        }

        public void MostrarInformacio()
        {
            Console.WriteLine($"Producte: {Nom}, Preu: {Preu:C}, Quantitat: {Quantitat}");
        }
    }
}
