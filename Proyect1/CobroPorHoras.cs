using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class CobroPorHoras
	{
		public void CobroHoras()
		{
			string dato = "";
			double horasUtilizadas = 0;
			double cobroPorHoras = 10.00;
			double totalDeCobro = 0;

			Console.WriteLine("Indique horas utilizadas");
			dato = Console.ReadLine();
			horasUtilizadas = Convert.ToDouble(dato);

			totalDeCobro = horasUtilizadas * cobroPorHoras;

			Console.WriteLine("El total de cobro por hora es {0}", totalDeCobro);
		}
	}
}
