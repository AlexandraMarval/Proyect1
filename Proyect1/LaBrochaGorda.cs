using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class LaBrochaGorda
	{
		public void LaGorda()
		{
			string dato;
			double alto = 0.0;
			double ancho = 0.0;
			double area = 0.0;
			double cobroporMtros = 0.0;
			double totalCobroPorMtro = 0;

			Console.WriteLine("Indique cuando mide de alto");
			dato = Console.ReadLine();
			alto = Convert.ToDouble(dato);

			Console.WriteLine("Indique cuando mide por ancho");
			dato = Console.ReadLine();
			ancho = Convert.ToDouble(dato);

			area = alto * ancho;

			Console.WriteLine("El area es {0}", area);

			Console.WriteLine("Indique Monto de cobro");
			dato = Console.ReadLine();
			cobroporMtros = Convert.ToDouble(dato);

			totalCobroPorMtro = cobroporMtros * area;

			Console.WriteLine("Total de cobro es {0}", totalCobroPorMtro);
		}
	}
}
