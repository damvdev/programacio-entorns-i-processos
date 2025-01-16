using System;

namespace exemples
{
    public class Colour
    {
        //comptador d'instàncies
        private static int _count = 0;

        //valor mínim i màxim per a cada color
        public const int MinValue = 0;
        public const int MaxValue = 255;
        public const string DefaultName = "No name";


        //propietats de l'objecte
        public string? Name { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        //constructor de major càrrega lògica
        public Colour(int red, int green, int blue, string name) {
            Red = red;
            Green = green;
            Blue = blue;
            Name = name;
            _count++;
        }

        public Colour(int red, int green, int blue) : this(red, green, blue, DefaultName) { }

        public Colour() : this(MinValue, MinValue, MinValue, DefaultName) { }

        public static int GetCount() => _count;

        public string ToRGB(bool upper) {
            return (upper ? "RGB" : "rgb" ) + $"({Red}, {Green}, {Blue})";
        }

        public string ToRGB() => ToRGB(false);
        
        public string ToHex()
        {
            return $"#{MyMath.DecimalToHex(Red)}{MyMath.DecimalToHex(Green)}{MyMath.DecimalToHex(Blue)}";
        }

        public static Colour Random() { 
            return new Colour(MyMath.NextInt(MaxValue), MyMath.NextInt(MaxValue), MyMath.NextInt(MaxValue));
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Colour c = (Colour)obj;
            return Red == c.Red && Green == c.Green && Blue == c.Blue;
        }
        public override int GetHashCode() => (Red, Green, Blue).GetHashCode();

        public override string ToString()
        {
            return $"Name: {Name}, RGB: ({Red}, {Green}, {Blue})";
        }

        public string GetInfoRGB(bool upper)
        {
            return upper ? $"RGB: ({Red}, {Green}, {Blue})" : $"rgb: ({Red}, {Green}, {Blue})";
        }
    }
}
