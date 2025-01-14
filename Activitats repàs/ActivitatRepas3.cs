using System;

public class Program
{
    public static void Main()
    {
        const string MsgCaseTriangleBase = "Introdueix la base del triangle: ";
        const string MsgCaseTriangleHeight = "Introdueix l'altura del triangle: ";
        const string MsgCaseCircle = "Introdueix el radi del cercle: ";
        const string MsgCaseSquare = "Introdueix el costat del quadrat: ";
        const string MsgResult = "L'àrea és: {0:F2}";
        const string MsgExit = "Sortint del programa. Adéu!";
        const string MsgError = "Opció no vàlida. Si us plau, torna-ho a intentar.";

        double area;
        bool exit = false;

        while (!exit)
        {
            ShowMenu();
            try
            {
                int option = GetMenuOption();

                switch (option)
                {
                    case 1:
                        Console.Write(MsgCaseTriangleBase);
                        double baseTriangle = GetPositiveDouble();

                        Console.Write(MsgCaseTriangleHeight);
                        double height = GetPositiveDouble();

                        area = CalculateArea(baseTriangle, height);
                        Console.WriteLine(MsgResult, area);

                        break;
                    case 2:
                        Console.Write(MsgCaseCircle);
                        double radius = GetPositiveDouble();

                        area = CalculateArea(radius);
                        Console.WriteLine(MsgResult, area);
                        break;
                    case 3:
                        Console.Write(MsgCaseSquare);
                        double side = GetPositiveDouble();

                        area = CalculateArea(side);
                        Console.WriteLine(MsgResult, area);
                        break;
                    case 4:
                        exit = true;
                        Console.WriteLine(MsgExit);
                        break;
                    default:
                        Console.WriteLine(MsgError);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public static double GetPositiveDouble()
    {
        const string ErrorMessage = "El valor ha de ser un nombre positiu.";
        if (!double.TryParse(Console.ReadLine(), out double value) || value <= 0)
        {
            throw new FormatException(ErrorMessage);
        }
        return value;
    }

    public static void ShowMenu()
    {
        const string Menu = "\n--- Menú ---" +
                            "\n1. Calcular àrea d'un triangle" +
                            "\n2. Calcular àrea d'un cercle" +
                            "\n3. Calcular àrea d'un quadrat" +
                            "\n4. Sortir" +
                            "\nSelecciona una opció: ";
        Console.WriteLine(Menu);

    }

    public static int GetMenuOption()
    {
        const string ErrorMessage = "Opció no vàlida. Si us plau, torna-ho a intentar.";

        if (!int.TryParse(Console.ReadLine(), out int option))
        {
            throw new FormatException(ErrorMessage);
        }
        return option;
    }

    public static double CalculateArea(double baseTriangle, double height)
    {
        return (baseTriangle * height) / 2;
    }

    public static double CalculateArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public static double CalculateArea(double side, bool isSquare = true)
    {
        return Math.Pow(side, 2);
    }
}
