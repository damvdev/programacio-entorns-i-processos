using System;
using System.Collections;
using System.Text;

namespace colleccions
{
    public class Program
    {
        public delegate void MyDelegate(int a, int b);
        public delegate int Operacio(int a, int b);
        public delegate void Notificacio(string missatge);

        public static void Sumar(int a, int b) { Console.WriteLine(a + b); }
        public static void Restar(int a, int b) { Console.WriteLine(a - b); }

        public static int Resta(int a, int b) { return a - b; }

        public static void MostrarMissatge(string missatge) => Console.WriteLine(missatge);
        public static int ExecutarOperacio(int a, int b, Operacio ops) => ops(a, b);

        public static void ExecutarAmbMetodeAnonim(Notificacio notificacio) {
            notificacio("Això és un mètode anònim!");
        }
    

        public static void Main()
        {
            MyDelegate delegat = Sumar;
            delegat += Restar;
            delegat(2, 5);

            Action<string> mostrar = msg => Console.WriteLine(msg);
            mostrar("Hola delegats");

            Func<int, int, int> multiplicacio = (a, b) => a * b;
            Console.WriteLine(multiplicacio(4,5));

            Predicate<int> esParell = (num) => num % 2 == 0;
            Console.WriteLine(esParell(3));
            Console.WriteLine(esParell(4));

            Publicador pub = new Publicador();
            pub.MissatgeEnviat += MostrarMissatge;
            pub.EnviarMissatge("Event enviat");

            MyDelegate op = delegate (int a, int b)
            {
                Console.WriteLine($"la suma és {a + b}");
            };

            MyDelegate op2 = (int a, int b) => Console.WriteLine($"la suma és {a + b}");

            op(3, 6);
            op(9, 4);

            op2(3, 6);
            op2(9, 4);

            Func<int, int> quadrat = x => x * x;
            Console.WriteLine(quadrat(5));

            Func<int, int, int> suma = (x, y) =>
            {
                int resultat = x + y;
                return resultat;
            };

            int resul = suma(3, 6);
            Console.WriteLine(resul);

            Action saluda = () => Console.WriteLine("Hola gent!");
            saluda();

            Console.WriteLine(ExecutarOperacio(10, 5, Resta));

            ExecutarAmbMetodeAnonim(delegate (string missatge)
            {
                Console.WriteLine($"[Missatge]: {missatge}");

            }
            );
        }
    }
}
