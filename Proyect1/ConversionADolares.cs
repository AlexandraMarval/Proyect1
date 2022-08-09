using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class ConversionADolares
	{
		public void ConversionDolares()
		{
			string dato;
			double euros;
			double tasaConversion = 1.03;
			double conversion;

			Console.WriteLine("Monto en Euros");
			dato = Console.ReadLine();
			euros = Convert.ToDouble(dato);

			conversion = euros * tasaConversion;

			Console.WriteLine("La cantidad en dolares es {0}", conversion);
		}
	}
}
