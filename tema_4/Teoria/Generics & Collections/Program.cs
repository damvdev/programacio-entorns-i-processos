using System;
using System.Collections;

namespace colleccions
{
    public class Program
    {
       public static void Main()
        {
            /*
             *
            Console.WriteLine("******************* Array ********************");
            int[] arrayInt = [1,2,3,4,5,6,7,8,9];
            int[] destArray = new int[20];
            int[] ints = new int[20];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                destArray[i] = arrayInt[i];
            }
            foreach (int i in destArray)
            {
                Console.WriteLine(i);
            }

            Array.Copy(arrayInt, ints, arrayInt.Length);

            Console.WriteLine("******************* Generic classes & methods ********************");
            Console.WriteLine(Generic.AreEqual<int>(3,2));
            Console.WriteLine(Generic.AreEqual<string>("Hola", "si"));
            Console.WriteLine(Generic.AreEqual<Person>(new Person("John", "Doe"), new Person("John", "Doe")));
            Generic.Display<int>("Entero", 3);
            Generic.Display<string>("Cadena", "Hola");
            Generic.Display<Person>("Persona", new Person("John", "Doe"));
            Generic.ShowMessage("mètode normal");
         

            Caixa<int> caixaEntera = new Caixa<int>(42);
            caixaEntera.MostrarContingut();

            Caixa<string> caixaText = new Caixa<string>("Hola generics!");
            caixaText.MostrarContingut();
               */

            Console.WriteLine("******************* ArrayList ********************");
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add(4);
            arrList.Add(3);
            arrList.Add(5);

            foreach (var item in arrList) {
                Console.WriteLine(item);
            }
            arrList.Sort();
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******************* HashTable ********************");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            hashtable.Add(3, 3);

            foreach (DictionaryEntry item in hashtable) {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("******************* SortedList ********************");
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "One");
            sortedList.Add(3, "Three");
            sortedList.Add(2, "Two");

            foreach (DictionaryEntry item in sortedList) {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("******************* Queue ********************");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(4);

            foreach (var item in queue) {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******************* Stack ********************");
            Stack pila = new Stack();
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            foreach (var item in pila) {
                Console.WriteLine(item);
            }

            Console.WriteLine("******************* List ********************");
            List<Person> llistaPersones = new List<Person>();
            llistaPersones.Add(new Person("Maria", "Garcia"));
            llistaPersones.Add(new Person("Miquel", "Biada"));
            llistaPersones.Sort();

            foreach(var item in llistaPersones)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******************* Dictionary ********************");
            Dictionary<int, string> personDict = new Dictionary<int, string>();
            personDict.Add(1, "Maria");
            personDict.Add(2, "Jaume");
            personDict.Add(3, "Helena");

            foreach (var item in personDict) {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Console.WriteLine("******************* Generic Queue ********************");
            Queue<int> queueInt = new Queue<int>();
            queueInt.Enqueue(1);
            queueInt.Enqueue(3);
            queueInt.Enqueue(2);
            queueInt.Enqueue(4);

            foreach (int item in queueInt)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******************* Generic Stack ********************");
            Stack<int> employeeStack = new Stack<int>();
            employeeStack.Push(1);
            employeeStack.Push(3);
            employeeStack.Push(2);
            foreach (var item in employeeStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}