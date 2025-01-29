using System;

namespace practica
{
	// Subclasse per al sistema solar
	public class SistemaSolar : SistemaEnergia
	{
		private double horesDeSol;

		public SistemaSolar()
		{
			Nom = "Sistema Solar";
		}

		public override void ConfigurarParametres()
		{
			Console.Write("Introdueix les hores de sol disponibles: ");
			if (!double.TryParse(Console.ReadLine(), out horesDeSol))
			{
				Console.WriteLine("Entrada invàlida. S'establirà un valor predeterminat de 5 hores.");
				horesDeSol = 5;
			}
		}
		public override void CalcularEnergia()
		{
			EnergiaGenerada = horesDeSol * 1.5; // Ex: 1.5 kWh per hora de sol
		}
	}
}
