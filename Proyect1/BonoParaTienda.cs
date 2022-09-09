using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class BonoParaTienda
	{
		public void BonoTienda()
		{
			int anosTienda = 0;
			double MontoTotal = 0;

			Console.WriteLine("Indique años en la tienda");
			anosTienda = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Su monto de bono de sueldo es:");
			MontoTotal = Bono(anosTienda);
			Console.WriteLine("{0}", MontoTotal);
		}	
		private double Bono(int anosTienda)
		{
			switch (anosTienda)
			{
				case 1:
					return 100;
				case 2:
					return 200;
				case 3:
					return 300;
				case 4:
					return 400;
				case 5:
					return 500;
				case > 5:
					return 1000;
				default:
					return 0;
			}
		}		
	}
}
