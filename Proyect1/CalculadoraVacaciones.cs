namespace Proyect1
{
	using System;

	public class CalculadoraVacaciones
	{
		public void Calcular()
		{
			var lugarDestino = DeterminarLugarDestino();
			var cantidadKilometros = DeterminarCantidadKilometros(lugarDestino);
			var precioPorKilometro = DeterminarPrecioPorKilometros();
			var precioTotal = DeterminarPrecioTotal(cantidadKilometros, precioPorKilometro);
			Console.WriteLine($"El monto a pagar son {precioTotal}");
		}

		private int DeterminarLugarDestino()
		{
			var continuar = true;
			var opcionSeleccionada = 0;

			Console.WriteLine(@"
Indique su lugar de destino 
	1. México 
	2. P.V. 
	3. Acapulco 
	4. Cancún");

			while (continuar)
			{
				var seleccion = Console.ReadLine();
				switch (seleccion)
				{
					case "1":
						opcionSeleccionada = 1;
						continuar = false;
						break;
					case "2":
						opcionSeleccionada = 2;
						continuar = false;
						break;
					case "3":
						opcionSeleccionada = 3;
						continuar = false;
						break;
					case "4":
						opcionSeleccionada = 4;
						continuar = false;
						break;
					default:
						Console.WriteLine("La opción seleccionada no es válida");
						break;
				}
			}

			return opcionSeleccionada;
		}

		private int DeterminarCantidadKilometros(int lugarDestino)
		{
			switch (lugarDestino)
			{
				case 1:
					return 750;
				case 2:
					return 800;
				case 3:
					return 1200;
				case 4:
					return 1800;
				default:
					return 0;
			}
		}

		private double DeterminarPrecioPorKilometros()
		{
			Console.WriteLine("Indique el precio por Kilometro");
			return Convert.ToDouble(Console.ReadLine());
		}

		private double DeterminarPrecioTotal(int cantidadKilometros, double precioPorKilometro)
		{
			return cantidadKilometros * precioPorKilometro * 2;
		}
	}
}
