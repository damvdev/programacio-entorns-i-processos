/* Ex1. Implementa un programa en C# que rebi un 
* nombre enter per teclat i retorni si aquest està 
  entre el 5 i el 100 (no inclosos) i no és senar */

using System;

public class Program
{
    const int MinValue = 5;
    const int MaxValue = 100;
    const int Divider = 2;
    const string Msg = "Introdueix un nombre enter: ";
    const string ErrorMessage = "El número {0} no compleix les condicions.";
    const string SuccessMessage = "El número {0} compleix les condicions.";
    public static void Main()
    {
        int number = GetNumberFromUser(Msg);
        Console.WriteLine(IsValidNumber(number, MinValue, MaxValue, Divider) ? SuccessMessage : ErrorMessage, number);
    }

    public static int GetNumberFromUser(string msg)
    {
        const string ErrorMsg = "Error: Introdueix un nombre vàlid.";
        bool isValidInput = false;
        int number = 0;

        do
        {
            Console.Write(msg);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine(ErrorMsg);
            }
        } while (!isValidInput);

        return number;
    }

    public static bool IsValidNumber(int number, int MinValue, int MaxValue, int value)
    {
        const int Remainder = 0;
        return number > MinValue && number < MaxValue && number % value == Remainder;
    }
}
