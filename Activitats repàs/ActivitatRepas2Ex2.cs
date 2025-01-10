/* 
 * Ex2. Implementa un programa en C# que mostri 
 * per pantalla el més gran de tres 
 * números introduïts per teclat
 */

using System;

public class Program
{
	public static void Main()
	{
		const string MsgUser = "Introdueix tres números:";
		const string MsgGetFirstNumber = "Primer número: ";
		const string MsgGetSecondNumber = "Segon número: ";
		const string MsgGetThirdNumber = "Tercer número: ";
		const string MsgMaxNumber = "El número més gran és: {0}";

		Console.WriteLine(MsgUser);

		int num1 = GetNumberFromUser(MsgGetFirstNumber);
		int num2 = GetNumberFromUser(MsgGetSecondNumber);
		int num3 = GetNumberFromUser(MsgGetThirdNumber);

		int maxim = CalculateMaxNumber(num1, num2, num3);

		Console.WriteLine(MsgMaxNumber, maxim);
		
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

	public static int CalculateMaxNumber(int a, int b, int c)
	{
		int maxim = a;
		if (b > maxim)
		{
			maxim = b;
		}
		if (c > maxim)
		{
			maxim = c;
		}
		return maxim;
	}
}
