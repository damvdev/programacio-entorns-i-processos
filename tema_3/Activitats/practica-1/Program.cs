using System;

namespace practica {
	public class Program
	{
		public static void Main()
		{
			Console.Write("Quantes simulacions vols guardar? ");
			if (!int.TryParse(Console.ReadLine(), out int nombreSimulacions) || nombreSimulacions <= 0)
			{
				Console.WriteLine("Entrada invàlida. S'establirà un límit de 5 simulacions.");
				nombreSimulacions = 5;
			}

			GestorSistema.InicialitzarGestor(nombreSimulacions);

			bool sortir = false;

			while (!sortir)
			{
				Console.WriteLine("\n--- Aplicació de Simulació d'Energia Renovable ---");
				Console.WriteLine("1. Iniciar simulació\n2. Veure informe del sistema actual\n3. Sortir");
				Console.Write("Selecciona una opció: ");

				switch (Console.ReadLine())
				{
					case "1":
						GestorSistema.IniciarSimulacio();
						break;
					case "2":
						GestorSistema.MostrarInforme();
						break;
					case "3":
						sortir = true;
						Console.WriteLine("Sortint de l'aplicació. Fins aviat!");
						break;
					default:
						Console.WriteLine("Opció invàlida. Intenta-ho de nou.");
						break;
				}
			}
		}
	}
}
