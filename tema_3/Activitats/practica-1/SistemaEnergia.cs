using System;

namespace practica
{
	// Classe abstracta per als sistemes d'energia
	public abstract class SistemaEnergia : ICalculEnergia
	{
		public string Nom { get; protected set; }
		public double EnergiaGenerada { get; protected set; }

		public abstract void ConfigurarParametres();
		public abstract void CalcularEnergia();
		public virtual void MostrarInforme()
		{
			Console.WriteLine($"Sistema: {Nom}\nEnergia generada: {EnergiaGenerada} kWh\n");
		}
	}

}
