/*
 * 21.d) Calcular l'àrea d'un triangle rectangle, 
 * la base del qual mesura B cm i la seva alçada A cm. 
 */

using System;
namespace Activitats
{
	public class Program
	{
		public static void Main()
		{
			const string MsgUIBase = "Introdueix la base del triangle: ";
			const string MsgUIHeight = "Introdueix l'altura del triangle: ";
			const string MsgUIResult = "L'àrea del triangle és: {0:0.00} cm².";
			const string MsgErrorBase = "Error: L'altura del triangle ha de ser un número.";
			const string MsgErrorHeight = "Error: La base del triangle ha de ser un número.";

			Console.WriteLine(MsgUIBase);
			try
			{
				float baseTriangle = (float)Convert.ToDouble(Console.ReadLine());
				Console.WriteLine(MsgUIHeight);
				try
				{
					float heightTriangle = (float)Convert.ToDouble(Console.ReadLine());
					float areaTriangle = (baseTriangle * heightTriangle) / 2;
					//mostra el resultat amb 2 decimals
					Console.WriteLine(MsgUIResult, areaTriangle);
				}
				catch (FormatException)
				{
					Console.WriteLine(MsgErrorBase);
				}
			}
			catch (FormatException)
			{
				Console.WriteLine(MsgErrorHeight);
			}
		}
	}
}