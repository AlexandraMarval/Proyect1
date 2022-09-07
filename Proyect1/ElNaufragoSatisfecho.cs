namespace Proyect1
{
	public class ElNaufragoSatisfecho
	{
		public void Ejecutar()
		{
			int cantidadHamburguesa = 0;
			int opcion = 0;
			double precioTotalPagar = 0.0;
			double precioHamburguesa = 0.0;

			Console.WriteLine("Indique que hamburguesas desea? 1 Hamburguesa Sencilla, 2 Hamburguesa Doble, 3 Hamburguesa Triple");
			opcion = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Indique la cantidad de hamburguesa");
			cantidadHamburguesa = Convert.ToInt32(Console.ReadLine());
			precioHamburguesa = ObtenerPrecioPorTipoDeHamburguesa_V3(opcion);

			precioTotalPagar = cantidadHamburguesa * precioHamburguesa;

			Console.WriteLine("Indique metodo de pago. 1. Efectivo 2. Tarjeta");
			opcion = Convert.ToInt32(Console.ReadLine());

			if (opcion == 2)
			{
				precioTotalPagar = precioTotalPagar * 1.05;
			}

			Console.WriteLine($"El precio a pagar es de {precioTotalPagar} por {cantidadHamburguesa} hamburguesas");
		}
		
		private double ObtenerPrecioPorTipoDeHamburguesa_V3(int tipoHamburguesa)
		{
			switch (tipoHamburguesa)
			{
				case 1:
				
					return 20.0;
				case 2:
					return 25.0;
				case 3:
					return 28.0;
				default:
					return 0;
			}
		}

		private double ObtenerPrecioPorTipoDeHamburguesa_V2(int tipoHamburguesa)
		{
			double precioHamburguesa = 0;

			switch (tipoHamburguesa)
			{
				case 1:
					precioHamburguesa = 20.0;
					break;
				case 2:
					precioHamburguesa = 25.0;
					break;
				case 3:
					precioHamburguesa = 28.0;
					break;
				default:
					break;
			}

			return precioHamburguesa;
		}

		
		private double ObtenerPrecioPorTipoDeHamburguesa_V1(int tipoHamburguesa)
		{
			if (tipoHamburguesa == 1)
				return 20.0;
			else if (tipoHamburguesa == 2)
				return 25.0;
			else if (tipoHamburguesa == 3)
				return 28.0;
			else
				return 0;
		}

		private double ObtenerPrecioPorTipoDeHamburguesa_V0(int tipoHamburguesa)
		{
			double precioHamburguesa = 0;
			
			if( tipoHamburguesa == 1)
			{
				precioHamburguesa = 20.0;
			}
			else if (tipoHamburguesa == 2)
			{
				precioHamburguesa = 25.0;
			}
			else if (tipoHamburguesa == 3)
			{
				precioHamburguesa = 28.0;
			}

			return precioHamburguesa;
		}
	}
}
