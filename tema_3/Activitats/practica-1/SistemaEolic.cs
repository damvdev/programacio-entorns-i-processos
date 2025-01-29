using System;

namespace practica
{
	// Subclasse per al sistema eòlic
	class SistemaEolic : SistemaEnergia
	{
		private double velocitatVent;

		public SistemaEolic()
		{
			Nom = "Sistema Eòlic";
		}

		public override void ConfigurarParametres()
		{
			Console.Write("Introdueix la velocitat del vent (m/s): ");
			if (!double.TryParse(Console.ReadLine(), out velocitatVent))
			{
				Console.WriteLine("Entrada invàlida. S'establirà un valor predeterminat de 10 m/s.");
				velocitatVent = 10;
			}
		}

		public override void CalcularEnergia()
		{
			EnergiaGenerada = Math.Pow(velocitatVent, 3) * 0.2; // Ex: energia proporcional al cub de la velocitat
		}
	}
}
