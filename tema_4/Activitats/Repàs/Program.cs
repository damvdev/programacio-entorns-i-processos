/************************* Ex.1 ************************************/
using System;

public class Contenidor<T>
{
    public T Valor { get; set; }

    public Contenidor(T valor)
    {
        Valor = valor;
    }

    public void MostrarValor()
    {
        Console.WriteLine($"El valor emmagatzemat és: {Valor}");
    }
}

public class Program
{
    public static void Main()
    {
        // Utilització amb un int
        Contenidor<int> contenidorInt = new Contenidor<int>(42);
        contenidorInt.MostrarValor(); // Sortida: El valor emmagatzemat és: 42

        // Utilització amb un string
        Contenidor<string> contenidorString = new Contenidor<string>("Hola, món!");
        contenidorString.MostrarValor(); // Sortida: El valor emmagatzemat és: Hola, món!

        // Utilització amb un DateTime
        Contenidor<DateTime> contenidorDate = new Contenidor<DateTime>(DateTime.Now);
        contenidorDate.MostrarValor(); // Sortida: El valor emmagatzemat és: [data actual]
    }
}
/************************* Ex.2 ************************************/
using System;

public class Parella<T1, T2>
{
    public T1 Primer { get; set; }
    public T2 Segon { get; set; }

    public Parella(T1 primer, T2 segon)
    {
        Primer = primer;
        Segon = segon;
    }

    public void MostrarValors()
    {
        Console.WriteLine($"Primer: {Primer}, Segon: {Segon}");
    }
}

public class Program
{
    static void Main()
    {
        // Parella de string i int
        Parella<string, int> parella1 = new Parella<string, int>("Edat", 25);
        parella1.MostrarValors(); // Sortida: Primer: Edat, Segon: 25

        // Parella de double i bool
        Parella<double, bool> parella2 = new Parella<double, bool>(3.14, true);
        parella2.MostrarValors(); // Sortida: Primer: 3.14, Segon: True
    }
}
/************************* Ex.3 ************************************/
using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        // Creem un ArrayList i afegim elements
        ArrayList arrayList = new ArrayList { 42, "Hola", 3.14, true };

        // Mostrem els valors de l'ArrayList
        Console.WriteLine("Valors de l'ArrayList:");
        foreach (var element in arrayList)
        {
            Console.WriteLine(element);
        }

        // Eliminem l'element 3.14
        arrayList.Remove(3.14);

        // Mostrem l'ArrayList actualitzat
        Console.WriteLine("\nArrayList després d'eliminar 3.14:");
        foreach (var element in arrayList)
        {
            Console.WriteLine(element);
        }
    }
}
/************************* Ex.4 ************************************/
using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        // Creem un Hashtable
        Hashtable hashtable = new Hashtable();

        // Afegim parells clau-valor
        hashtable.Add("Nom", "Joan");
        hashtable.Add("Edat", 25);

        // Mostrem els valors emmagatzemats al Hashtable
        Console.WriteLine("Valors emmagatzemats al Hashtable:");
        foreach (DictionaryEntry entrada in hashtable)
        {
            Console.WriteLine($"{entrada.Key}: {entrada.Value}");
        }

        // Comprovem si una clau existeix al Hashtable
        string clauABuscar = "Ciutat";
        if (hashtable.ContainsKey(clauABuscar))
        {
            Console.WriteLine($"La clau '{clauABuscar}' existeix al Hashtable.");
        }
        else
        {
            Console.WriteLine($"La clau '{clauABuscar}' NO existeix al Hashtable.");
        }
    }
}
/************************* Ex.5 ************************************/
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Creem una List<int> amb els valors [10, 20, 30, 40, 50]
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

        // Afegim el valor 60 al final de la llista
        numeros.Add(60);

        // Eliminem el valor 30 de la llista
        numeros.Remove(30);

        // Ordenem la llista en ordre descendent amb LINQ
        var llistaOrdenadaDescendent = numeros.OrderByDescending(n => n).ToList();

        // Mostrem la llista ordenada
        Console.WriteLine("Llista ordenada en ordre descendent:");
        llistaOrdenadaDescendent.ForEach(Console.WriteLine);
    }
}
/************************* Ex.6 ************************************/
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Creem un Dictionary<string, double> per emmagatzemar preus de productes
        Dictionary<string, double> preus = new Dictionary<string, double>
        {
            { "Poma", 1.20 },
            { "Llet", 0.90 },
            { "Pa", 1.50 }
        };

        // Mostrem els preus dels productes
        Console.WriteLine("Preus dels productes:");
        foreach (var producte in preus)
        {
            Console.WriteLine($"{producte.Key}: {producte.Value}€");
        }

        // Comprovem si el producte "Aigua" existeix al diccionari
        string producteABuscar = "Aigua";
        if (preus.ContainsKey(producteABuscar))
        {
            Console.WriteLine($"\nEl producte '{producteABuscar}' existeix al diccionari.");
        }
        else
        {
            Console.WriteLine($"\nEl producte '{producteABuscar}' NO existeix al diccionari.");
        }
    }
}
/************************* Ex.7 ************************************/
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Creem una llista de noms
        List<string> noms = new List<string> { "Anna", "Joan", "Maria", "Pere" };

        // Mostrem la llista original
        Console.WriteLine("Llista original:");
        noms.ForEach(Console.WriteLine);

        // Ordenem la llista alfabèticament amb LINQ
        var llistaOrdenada = noms.OrderBy(n => n).ToList();
        Console.WriteLine("\nLlista ordenada alfabèticament:");
        llistaOrdenada.ForEach(Console.WriteLine);

        // Ordenem la llista en ordre invers amb LINQ
        var llistaInversa = noms.OrderByDescending(n => n).ToList();
        Console.WriteLine("\nLlista ordenada en ordre invers:");
        llistaInversa.ForEach(Console.WriteLine);
    }
}
/************************* Ex.8 ************************************/
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numeros = new List<int> { 15, 3, 8, 20, 10 };
        
        // Ordena la llista en ordre ascendent
        numeros.Sort();
        Console.WriteLine("Llista ordenada ascendent:");
        numeros.ForEach(n => Console.WriteLine(n));
        
        // Ordena en descendent amb LINQ
        var descendent = numeros.OrderByDescending(n => n);
        Console.WriteLine("\nLlista ordenada descendent amb LINQ:");
        descendent.ToList().ForEach(n => Console.WriteLine(n));
    }
}
/************************* Ex.9 ************************************/
using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        List<int> numeros = new List<int> { 5, 10, 15, 20, 25, 30 };
        
        // Filtra nombres parells
        var parells = numeros.Where(n => n % 2 == 0);
        Console.WriteLine("Números parells:");
        foreach (int num in parells)
        {
            Console.WriteLine(num);
        }
        
        // Filtra nombres majors de 15
        var majors15 = numeros.Where(n => n > 15);
        Console.WriteLine("\nNúmeros majors de 15:");
        foreach (int num in majors15)
        {
            Console.WriteLine(num);
        }
    }
}
/************************* Ex.10 ************************************/
using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        List<string> paraules = new List<string> { "Hola", "Món", "C#", "Programació", "LINQ" };
        
        var paraulesAmbP = paraules.Where(p => p.StartsWith("P"));
        
        Console.WriteLine("Paraules que comencen amb 'P':");
        foreach (var paraula in paraulesAmbP)
        {
            Console.WriteLine(paraula);
        }
    }
}
/************************* Ex.11 ************************************/
using System;
using System.Globalization;
public class Program
{
    public static void Main()
    {
        Console.Write("Introdueix una data (format dd/MM/yyyy): ");
        DateTime dataIntroduida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        TimeSpan diferencia = dataIntroduida - DateTime.Today;
        
        Console.WriteLine($"Falten {diferencia.Days} dies per a la data introduïda.");
    }
}
/************************* Ex.12 ************************************/
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine($"Avui és {DateTime.Today.DayOfWeek}.");
    }
}
/************************* Ex.13 ************************************/
using System;
using System.Globalization;
public class Program
{
    public static void Main()
    {
        Console.Write("Introdueix la teva data de naixement (format dd/MM/yyyy): ");
        DateTime dataNaixement = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        
        int edat = DateTime.Today.Year - dataNaixement.Year;
        if (dataNaixement.Date > DateTime.Today.AddYears(-edat))
        {
            edat--;
        }
        
        Console.WriteLine($"Tens {edat} anys.");
    }
}
/************************* Ex.14 ************************************/
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numeros = new List<int> { 12, 5, 8, 20, 15, 10 };
        
        // Números majors de 10 amb els seus quadrats
        var majorsDe10 = numeros.Where(n => n > 10)
                                .Select(n => new { Numero = n, Quadrat = n * n });
        
        Console.WriteLine("Números majors de 10 i els seus quadrats:");
        foreach (var item in majorsDe10)
        {
            Console.WriteLine($"{item.Numero} → {item.Quadrat}");
        }

        // Comptar quantes vegades apareix el 5
        int comptador5 = numeros.Count(n => n == 5);
        Console.WriteLine($"\nEl número 5 apareix {comptador5} vegades.");
    }
}
/************************* Ex.15 ************************************/
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> llenguatges = new List<string> { "C#", "Java", "Python", "JavaScript", "C++" };
        
        // Llenguatges amb més de 3 caràcters
        var llargs = llenguatges.Where(l => l.Length > 3);
        Console.WriteLine("Llenguatges amb més de 3 caràcters:");
        foreach (var llenguatge in llargs)
        {
            Console.WriteLine(llenguatge);
        }

        // Freqüència de caràcters
        var freqCaracters = llenguatges.SelectMany(l => l)
                                      .GroupBy(c => c)
                                      .Select(g => new { Caracter = g.Key, Freq = g.Count() });
        
        Console.WriteLine("\nFreqüència de caràcters:");
        foreach (var item in freqCaracters)
        {
            Console.WriteLine($"{item.Caracter}: {item.Freq}");
        }
    }
}using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        List<string> llenguatges = new List<string> { "C#", "Java", "Python", "JavaScript", "C++" };
        
        // Llenguatges amb més de 3 caràcters
        var llargs = llenguatges.Where(l => l.Length > 3);
        Console.WriteLine("Llenguatges amb més de 3 caràcters:");
        foreach (var llenguatge in llargs)
        {
            Console.WriteLine(llenguatge);
        }

        // Freqüència de caràcters
        var freqCaracters = llenguatges.SelectMany(l => l)
                                      .GroupBy(c => c)
                                      .Select(g => new { Caracter = g.Key, Freq = g.Count() });
        
        Console.WriteLine("\nFreqüència de caràcters:");
        foreach (var item in freqCaracters)
        {
            Console.WriteLine($"{item.Caracter}: {item.Freq}");
        }
    }
}
/************************* Ex.16 ************************************/
using System;
using System.Collections.Generic;
using System.Linq;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public string Product { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Customer> clients = new List<Customer>
        {
            new Customer { Id = 1, Name = "Anna" },
            new Customer { Id = 2, Name = "Marc" }
        };

        List<Order> comandes = new List<Order>
        {
            new Order { OrderId = 101, CustomerId = 1, Product = "Ordinador" },
            new Order { OrderId = 102, CustomerId = 1, Product = "Telèfon" },
            new Order { OrderId = 103, CustomerId = 2, Product = "Tauleta" }
        };

        // Junta clients i comandes
        var comandesPerClient = from client in clients
                                join comanda in comandes 
                                on client.Id equals comanda.CustomerId
                                select new { Client = client.Name, Producte = comanda.Product };

        Console.WriteLine("Comandes per client:");
        foreach (var item in comandesPerClient)
        {
            Console.WriteLine($"{item.Client} ha comprat {item.Producte}");
        }
    }
}
/************************* Ex.17 ************************************/
using System;
using System.Linq;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        var xml = XElement.Load("empleats.xml");
        var empleats = xml.Elements("empleat")
                          .Select(e => new
                          {
                              Nom = e.Element("nom").Value,
                              Cognom = e.Element("cognom").Value
                          });

        foreach (var emp in empleats)
        {
            Console.WriteLine($"Nom: {emp.Nom}, Cognom: {emp.Cognom}");
        }
    }
}
/************************* Ex.18 ************************************/
var empleatsMajors = xml.Elements("empleat")
                        .Where(e => int.Parse(e.Element("edat").Value) > 26)
                        .Select(e => new
                        {
                            Nom = e.Element("nom").Value,
                            Cognom = e.Element("cognom").Value
                        });

foreach (var emp in empleatsMajors)
{
    Console.WriteLine($"Nom: {emp.Nom}, Cognom: {emp.Cognom}");
}
/************************* Ex.19 ************************************/
var empleats = new[]
{
    new { Id = 1, Nom = "Joan", Cognom = "Garcia", Edat = 30 },
    new { Id = 2, Nom = "Anna", Cognom = "Martínez", Edat = 25 }
};

var xml = new XElement("empleats",
    empleats.Select(e => new XElement("empleat",
        new XElement("id", e.Id),
        new XElement("nom", e.Nom),
        new XElement("cognom", e.Cognom),
        new XElement("edat", e.Edat)
    ))
);

xml.Save("empleats_nou.xml");
/************************* Ex.20 ************************************/
using CsvHelper;
using System.Globalization;
using System.IO;

public class Program
{
    public static void Main()
    {
        using (var reader = new StreamReader("empleats.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var empleats = csv.GetRecords<Empleat>();

            foreach (var emp in empleats)
            {
                Console.WriteLine($"Nom: {emp.Nom}, Cognom: {emp.Cognom}");
            }
        }
    }
}

public class Empleat
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Cognom { get; set; }
    public int Edat { get; set; }
}
/************************* Ex.21 ************************************/
var empleats = new List<Empleat>
{
    new Empleat { Id = 1, Nom = "Joan", Cognom = "Garcia", Edat = 30 },
    new Empleat { Id = 2, Nom = "Anna", Cognom = "Martínez", Edat = 25 }
};

using (var writer = new StreamWriter("empleats_nou.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(empleats);
}
/************************* Ex.22 ************************************/
using System;
using System.Collections.Generic;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        var json = System.IO.File.ReadAllText("empleats.json");
        var empleats = JsonSerializer.Deserialize<List<Empleat>>(json);

        foreach (var emp in empleats)
        {
            Console.WriteLine($"Nom: {emp.Nom}, Cognom: {emp.Cognom}");
        }
    }
}

public class Empleat
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Cognom { get; set; }
    public int Edat { get; set; }
}
/************************* Ex.23 ************************************/
var empleats = new List<Empleat>
{
    new Empleat { Id = 1, Nom = "Joan", Cognom = "Garcia", Edat = 30 },
    new Empleat { Id = 2, Nom = "Anna", Cognom = "Martínez", Edat = 25 }
};

var json = JsonSerializer.Serialize(empleats, new JsonSerializerOptions { WriteIndented = true });
System.IO.File.WriteAllText("empleats_nou.json", json);
/************************* Ex.24 ************************************/
var empleatsMajors = empleats.Where(e => e.Edat > 26);

foreach (var emp in empleatsMajors)
{
    Console.WriteLine($"Nom: {emp.Nom}, Cognom: {emp.Cognom}");
}
/************************* Ex.25 ************************************/
//fitxer .cshtml
<form method="post">
    <div>
        <label asp-for="Empleat.Nom"></label>
        <input asp-for="Empleat.Nom" />
    </div>
    <div>
        <label asp-for="Empleat.Cognom"></label>
        <input asp-for="Empleat.Cognom" />
    </div>
    <div>
        <label asp-for="Empleat.Edat"></label>
        <input asp-for="Empleat.Edat" />
    </div>
    <div>
        <label asp-for="Empleat.Departament"></label>
        <input asp-for="Empleat.Departament" />
    </div>
    <button type="submit">Enviar</button>
</form>
//fitxer .cs
public class AfegirEmpleatModel : PageModel
{
    [BindProperty]
    public Empleat Empleat { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        // Guardar l'empleat a la base de dades o llista
        return RedirectToPage("LlistatEmpleats");
    }
}

/************************* Ex.26 ************************************/
//fitxer Empleat.cs
public class Empleat
{
    [Required(ErrorMessage = "El nom és obligatori")]
    public string Nom { get; set; }

    [Required(ErrorMessage = "El cognom és obligatori")]
    public string Cognom { get; set; }

    public int Edat { get; set; }

    [Required(ErrorMessage = "El departament és obligatori")]
    public string Departament { get; set; }
}
//fitxer .cshtml
<form method="post">
    <div>
        <label asp-for="Empleat.Nom"></label>
        <input asp-for="Empleat.Nom" />
        <span asp-validation-for="Empleat.Nom" class="text-danger"></span>
    </div>
    <div>
        <label asp-for="Empleat.Cognom"></label>
        <input asp-for="Empleat.Cognom" />
        <span asp-validation-for="Empleat.Cognom" class="text-danger"></span>
    </div>
    <div>
        <label asp-for="Empleat.Edat"></label>
        <input asp-for="Empleat.Edat" />
    </div>
    <div>
        <label asp-for="Empleat.Departament"></label>
        <input asp-for="Empleat.Departament" />
        <span asp-validation-for="Empleat.Departament" class="text-danger"></span>
    </div>
    <button type="submit">Enviar</button>
</form>
/************************* Ex.27 ************************************/
//fitxer Empleat.cs
public class Empleat
{
    [Required(ErrorMessage = "El nom és obligatori")]
    public string Nom { get; set; }

    [Required(ErrorMessage = "El cognom és obligatori")]
    public string Cognom { get; set; }

    [Range(18, 99, ErrorMessage = "L'edat ha de ser major que 18")]
    public int Edat { get; set; }

    [Required(ErrorMessage = "El departament és obligatori")]
    public string Departament { get; set; }
}
//fitxer .cshtml
<div>
    <label asp-for="Empleat.Edat"></label>
    <input asp-for="Empleat.Edat" />
    <span asp-validation-for="Empleat.Edat" class="text-danger"></span>
</div>
/************************* Ex.28 ************************************/
//fitxer LlistatEmpleatsModel.cs
public class LlistatEmpleatsModel : PageModel
{
    public List<Empleat> Empleats { get; set; }

    public void OnGet()
    {
        Empleats = new List<Empleat>
        {
            new Empleat { Nom = "Joan", Cognom = "Garcia", Edat = 30, Departament = "Vendes" },
            new Empleat { Nom = "Anna", Cognom = "Martínez", Edat = 25, Departament = "IT" }
        };
    }
}
//fitxer .cshtml
<table class="table">
    <thead>
        <tr>
            <th>Nom</th>
            <th>Cognom</th>
            <th>Edat</th>
            <th>Departament</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var empleat in Model.Empleats)
        {
            <tr>
                <td>@empleat.Nom</td>
                <td>@empleat.Cognom</td>
                <td>@empleat.Edat</td>
                <td>@empleat.Departament</td>
            </tr>
        }
    </tbody>
</table>
