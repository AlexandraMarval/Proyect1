using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class ElCometa
	{
		public void Cometa()
		{
			int opcion;			
			double descuento;
			double costoDeMateriaPrima;
			double costoDeManoDeObra;
			double gastoDeFabricacion;
			double costoDeProduccion;
			double PrecioDeVenta;
			
			Console.WriteLine("indique las claves del producto: 1, 2, 3, 4, 5, 6");
			opcion = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Costo de materia prima");
			costoDeMateriaPrima = Convert.ToDouble(Console.ReadLine());

			descuento = ObtenerDescuento(opcion);

			Console.WriteLine("Costo de mano de obra");
			costoDeManoDeObra = ObtenerCostoDeManoDeObra(costoDeMateriaPrima, descuento);
			Console.WriteLine("{0}", costoDeManoDeObra);

			Console.WriteLine("Gasto de fabricacion");
			gastoDeFabricacion = ObtenerGastoDeFabricacion(opcion, costoDeMateriaPrima, costoDeManoDeObra);
			Console.WriteLine("{0}", gastoDeFabricacion);

			Console.WriteLine("Costo de prodcuccion");
			costoDeProduccion = ObtenerCostoDeProduccion(costoDeMateriaPrima, costoDeManoDeObra, gastoDeFabricacion);
			Console.WriteLine("{0}", costoDeProduccion);

			PrecioDeVenta = ObtenerPrecioDeVenta(costoDeProduccion);

			Console.WriteLine("$El precio de venta es {0}", PrecioDeVenta);
		}

		private double ObtenerCostoDeManoDeObra(double costoDeMateriaPrima, double descuento)
		{
			return costoDeMateriaPrima * descuento;			
		}

		private double ObtenerDescuento(int codigoDeProducto)
		{
			if (codigoDeProducto == 3 || codigoDeProducto == 4)
				return 0.75;
			else if (codigoDeProducto == 1 || codigoDeProducto == 5)
				return 0.80;
			else if (codigoDeProducto == 2 || codigoDeProducto == 6)
				return 0.85;
			else
				return 0;
		}

		private double ObtenerGastoDeFabricacion(int codigoDeProducto, double costoDeMateriaPrima, double costoDeManoDeObra)
		{			
			double gastoDeFabricacion = 0.0;

			switch (codigoDeProducto)
			{
				case 1:
				case 4:
					gastoDeFabricacion = costoDeMateriaPrima * 0.28 + costoDeManoDeObra * 0.12;										
					break;
				case 2:
				case 5:
					gastoDeFabricacion = costoDeMateriaPrima * 0.30 + costoDeManoDeObra * 0.10;			
					break;
				case 3:
				case 6:
					gastoDeFabricacion = costoDeMateriaPrima * 0.35 + costoDeManoDeObra * 0.22;
					break;
			}
			return gastoDeFabricacion;
		}

		private double ObtenerCostoDeProduccion(double costoDeMateriaPrima, double costoDeManoDeObra, double gastoDeFabricacion)
		{
			return costoDeMateriaPrima + costoDeManoDeObra + gastoDeFabricacion;			
		}

		private double ObtenerPrecioDeVenta(double costoDeProduccion)
		{
			return costoDeProduccion * 1.45;
		}
	}
}