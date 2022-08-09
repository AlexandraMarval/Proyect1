using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class CalcularArea
	{				
		public void Calcular()
		{
			double Area = 0.0;
			double altura = 0.0;
			double largo = 0.0;
			string dato = "";

			Console.WriteLine("Indique la altura");
			dato = Console.ReadLine();
			altura = Convert.ToDouble(dato);

			Console.WriteLine("Indique el largo");
			dato = Console.ReadLine();
			largo = Convert.ToDouble(dato);

			Area = altura * largo;

			Console.WriteLine("El resultado del Area es {0}", Area);

		}
	}
}
