namespace Proyect1
{
	public class ViajeDeEstudio
	{
		public void Ejecutar()
		{
			Console.WriteLine($"Indique la cantidad de alumnos que asistiran");
			var costoPasaje = CalcularCostoPasaje();
			Console.WriteLine($"El costo del pasaje son {costoPasaje}");
		}

		private int CalcularCostoPasaje()
		{
			int costoPasaje;
			var cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

			switch (cantidadAlumnos)
			{
				case >= 100:
					costoPasaje = 20;
					break;
				case >= 50:
					costoPasaje = 35;
					break;
				case >= 20:
					costoPasaje = 40;
					break;
				case < 20:
					costoPasaje = 70;
					break;
			}

			return costoPasaje;
		}
	}
}
