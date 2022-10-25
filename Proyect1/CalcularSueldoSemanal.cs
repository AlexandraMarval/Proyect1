using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class CalcularSueldoSemanal
	{
		public void SueldoSemanal()
		{
			string datos = "";
			double horas = 0.0;
			double dinero = 0.0;
			double semanal = 0.0;

			Console.WriteLine("Cuantas horas a la semana trabaja");
			horas = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Cuanto dinero recibe por hora");		
			dinero = Convert.ToDouble(Console.ReadLine());

			semanal = horas * dinero;

			Console.WriteLine("El sueldo es {0}", semanal);
		}
	}
}
