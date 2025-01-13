using System;
namespace exemples;
public class Program {
    public static void Main() {
        Colour c1 = new Colour(255, 0, 0, "Red");
        Console.WriteLine(c1.GetInfo());

        var colorRandom = Colour.Random();
        Console.WriteLine(colorRandom.GetInfo());

        Console.WriteLine(Colour.GetCount());
        Console.WriteLine(colorRandom.ToRGB());
        Console.WriteLine(colorRandom.ToRGB(true));
    }
}
