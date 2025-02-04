using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colleccions
{
    public class Caixa<T>
    {
        public T Contingut { get; set; }

        public Caixa(T contingut) {
            Contingut = contingut;
        }

        public void MostrarContingut() {
            Console.WriteLine($"El contingut és:  {Contingut}");
        }
    }
}
