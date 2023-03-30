using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class ElNaufragoSastifecho2
	{
		public void HamburguesasNaufragoSatisfecho()
		{
			int opción = 0;			
			double preciosdehamburguesas = 0.0;
			double tiposhamburguesas;
			double hamburguesas;
			double cantidadDeHamburguesa;
			double totalPorPagar = 0.0;			
			
			Console.WriteLine("¿Indique que tipos de hamburguesas desea? 1 Sencilla, 2 Doble, 3 Triple");
			hamburguesas = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Indique cantidad de hamburguesas");
			tiposhamburguesas = Convert.ToInt32(Console.ReadLine());
			cantidadDeHamburguesa = PreciosTiposDeHamburguesas(preciosdehamburguesas);

			totalPorPagar = tiposhamburguesas * cantidadDeHamburguesa;			

			Console.WriteLine("¿Indique que opción desea cancelar? 1 Efectivo, 2 Tarjeta");
			opción = Convert.ToInt32(Console.ReadLine());			

			switch (opción)
			{	
				case 2:
					totalPorPagar = cantidadDeHamburguesa * 1.5;
					break;
			}
		
			Console.WriteLine($"El Precio de su hamburguesa es: {totalPorPagar}");
		}	
		private double PreciosTiposDeHamburguesas(double preciosdehamburguesas)
		{
			switch (preciosdehamburguesas)
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
	}
}