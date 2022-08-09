using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class OperacionesMatematicas
	{
		public void Matematicas()
		{
			int primer = 0;
			int segundo = 0;
			string dat = "";
			int opcion = 0;
			int resultado = 0;

			Console.WriteLine("Indique que operacion Matematica desea: 1 para Suma, 2 para division, 3 Adios");
			dat = Console.ReadLine();
			opcion = Convert.ToInt32(dat);

			if (opcion == 1)
			{
				Console.WriteLine("Indique primer numero");
				dat = Console.ReadLine();
				primer = Convert.ToInt32(dat);

				Console.WriteLine("Indique segundo numero");
				dat = Console.ReadLine();
				segundo = Convert.ToInt32(dat);

				resultado = primer + segundo;

				Console.WriteLine("El resultado de la suma es {0}", resultado);
			}
			else if (opcion == 2)
			{
				Console.WriteLine("Indique primer numero");
				dat = Console.ReadLine();
				primer = Convert.ToInt32(dat);

				Console.WriteLine("Indique primer numero");
				dat = Console.ReadLine();
				segundo = Convert.ToInt32(dat);

				resultado = primer / segundo;

				Console.WriteLine("El resultado de la Division es {0}", resultado);
			}
			else if (opcion == 3)
			{
				Console.WriteLine("Adios");
			}
		}
	}
}
