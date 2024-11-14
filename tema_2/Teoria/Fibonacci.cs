using System;
namespace Activities { 
	public class Program
	{
		public static int FibonacciSeries(int n)
		{
			if(n == 0) return 0;
			if (n == 1) return 1;
			return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
		}
		public static void Main()
		{
			const string MsgUser = "Introdueix el número a partir del qual es calcularà la successió de Fibonacci: ";

			Console.WriteLine(MsgUser);
			int length = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < length; i++)
			{
				Console.Write("{0} ", FibonacciSeries(i));
			}
		}
	}
}
