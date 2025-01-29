using System;

namespace practica
{
	// Interfície per als càlculs del sistema d'energia
	public interface ICalculEnergia
	{
		void ConfigurarParametres();
		void CalcularEnergia();
		void MostrarInforme();
	}
}
