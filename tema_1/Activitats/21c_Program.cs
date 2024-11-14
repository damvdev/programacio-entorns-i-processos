/*
 * 21.c) Donats dos nombres enters num1 i num2, 
 * retornar el resultat d’executar la divisió de num1 entre num2. 
 */

using System;
namespace Activitats
{
	public class Program
	{
		public static void Main()
		{
			const string MsgUIFirstNum = "Introdueix el dividend: ";
			const string MsgUISecondNum = "Introdueix el divisor: ";
			const string MsgUIResult = "El resultat és:";
			const string MsgUIResultError = "No es pot dividir per 0.";
			const string MsgFormatError = "Error: el valor introduït ha de ser un número.";

			Console.WriteLine(MsgUIFirstNum);
			try
			{
				int dividend = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(MsgUISecondNum);
				try
				{
					int divider = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine( divider != 0 ? $"{MsgUIResult} {dividend / divider}." : $"{MsgUIResultError}");
				}
				catch (FormatException)
				{
					Console.WriteLine(MsgFormatError);
				}
			}
			catch (FormatException)
			{
				Console.WriteLine(MsgFormatError);
			}
		}
	}
}
