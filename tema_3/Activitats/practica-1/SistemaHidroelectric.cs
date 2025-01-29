using System;


namespace practica
{
	// Subclasse per al sistema hidroelèctric
	class SistemaHidroelectric : SistemaEnergia
	{
		private double cabalAigua;

		public SistemaHidroelectric()
		{
			Nom = "Sistema Hidroelèctric";
		}

		public override void ConfigurarParametres()
		{
			Console.Write("Introdueix el cabal d'aigua (m^3/s): ");
			if (!double.TryParse(Console.ReadLine(), out cabalAigua))
			{
				Console.WriteLine("Entrada invàlida. S'establirà un valor predeterminat de 20 m^3/s.");
				cabalAigua = 20;
			}
		}

		public override void CalcularEnergia()
		{
			EnergiaGenerada = cabalAigua * 9.8 * 0.8; // Ex: energia proporcional al cabal
		}
	}
}
