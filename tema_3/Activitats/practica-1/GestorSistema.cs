using System;

namespace practica
{
	// Classe estàtica per a la gestió del sistema
	public static class GestorSistema
	{
		private static SistemaEnergia[] simulacions;
		private static int indexSimulacio = 0;

		public static void InicialitzarGestor(int nombreSimulacions)
		{
			simulacions = new SistemaEnergia[nombreSimulacions];
		}

		public static void IniciarSimulacio()
		{
			if (indexSimulacio >= simulacions.Length)
			{
				Console.WriteLine("S'ha assolit el límit de simulacions guardades.");
				return;
			}

			Console.WriteLine("Selecciona el tipus de sistema:\n1. Solar\n2. Eòlic\n3. Hidroelèctric");
			string opcio = Console.ReadLine();

			SistemaEnergia sistemaActiu;

			switch (opcio)
			{
				case "1":
					sistemaActiu = new SistemaSolar();
					break;
				case "2":
					sistemaActiu = new SistemaEolic();
					break;
				case "3":
					sistemaActiu = new SistemaHidroelectric();
					break;
				default:
					Console.WriteLine("Opció invàlida. Seleccionant sistema solar per defecte.");
					sistemaActiu = new SistemaSolar();
					break;
			}

			sistemaActiu.ConfigurarParametres();
			sistemaActiu.CalcularEnergia();
			simulacions[indexSimulacio] = sistemaActiu;
			indexSimulacio++;
			Console.WriteLine("Simulació completada.");
		}

		public static void MostrarInforme()
		{
			if (indexSimulacio == 0)
			{
				Console.WriteLine("No hi ha cap simulació registrada.");
				return;
			}

			Console.WriteLine("\n--- Informe de les Simulacions ---");
			Console.WriteLine("Tipus de Sistema\tEnergia Generada (kWh)");
			Console.WriteLine("-----------------------------------");

			for (int i = 0; i < indexSimulacio; i++)
			{
				var sistema = simulacions[i];
				Console.WriteLine($"{sistema.Nom}\t{sistema.EnergiaGenerada:F2}");
			}

			Console.WriteLine("-----------------------------------\n");
		}
	}
}
