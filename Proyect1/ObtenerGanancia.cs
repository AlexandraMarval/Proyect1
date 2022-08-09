using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class ObtenerGanancia
	{
		public void Ganancia()
		{
			string obtener = "";
			double litros = 0.0;
			double galon = 3.785;
			double preciogalones = 0.0;
			double galones = 0.0;
			double ganancia = 0.0;

			Console.WriteLine("cuantos litros saco hoy");
			obtener = Console.ReadLine();
			litros = Convert.ToDouble(obtener);

			galones = litros / galon;

			Console.WriteLine("Cuantos le pagan por galon");
			obtener = Console.ReadLine();
			preciogalones = Convert.ToDouble(obtener);

			ganancia = preciogalones * galones;

			Console.WriteLine("La ganancia es {0}", ganancia);
		}
	}
}
