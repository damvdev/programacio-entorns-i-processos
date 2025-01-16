using System;
namespace exemples;
public class Program {
    public static void Main() {
        Animal animal = new Animal(10.5f, "Dog");
        Console.WriteLine(animal.GetFullInfo());
        Cat cat = new Cat(5.5f, "Kitty");
        Console.WriteLine(cat.GetFullInfo());
        
        Dog dog = new Dog(15.5f, "Rex");
        Dog dog1 = new Dog(15.5f, "Rex");
        Console.WriteLine(dog1 == dog);
        Console.WriteLine(dog1.Equals(dog));


        dog.Eat();
        AAnimal aDog = new Dog(20.5f, "Perry");
        aDog.Eat();

        var colorRandom = Colour.Random();
        Console.WriteLine(colorRandom.GetInfo());

        Console.WriteLine(Colour.GetCount());
        Console.WriteLine(colorRandom.ToRGB());
        Console.WriteLine(colorRandom.ToRGB(true));
        Console.WriteLine(colorRandom.ToHex());

       
        Colour c1 = new Colour(255, 0, 0, "Red");
        Console.WriteLine(c1.ToString());

        Colour c2 = new Colour(255, 0, 0, "Red");
        Console.WriteLine(c2.ToString());

        Console.WriteLine(c1==c2);
        Console.WriteLine(c1.Equals(c2));
        Console.WriteLine(c1.GetHashCode());
        Console.WriteLine(c2.GetHashCode());
         

        string text = null;
        Colour c3 = null;

        int? num = null;
        bool? flag = null;
        Console.WriteLine(text==null ? "La variable és nul·la" : "La variable NO és nul·la");
        string result = text ?? "La variable és nul·la";
        Console.WriteLine(result);

        int value = num ?? 3;
        Console.WriteLine(value);

        text ??= "Text per defecte";
        Console.WriteLine(text);
        Console.WriteLine(text == null ? "La variable és nul·la" : "La variable NO és nul·la");

        string cadena = null;
        int? len = cadena.Length;
        Console.WriteLine(len);
        

        try
        {
            Circle cercle = new Circle(-5, Colour.Random());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            
        }

    }
}
