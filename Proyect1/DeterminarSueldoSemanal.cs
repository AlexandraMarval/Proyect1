using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class DeterminarSueldoSemanal
	{
		public void SueldoSemanal()
		{
			double horasSemanal = 0.0;
			double pagosPorHoras = 0.0;
			double sueldoSemanal = 0.0;
			
			Console.WriteLine("Indique pagos por horas");
			horasSemanal = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Indique el pago que le pagan por horas");
			pagosPorHoras = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Indique sueldo semanal");
			sueldoSemanal = CobroPorHoras(horasSemanal, pagosPorHoras);
			Console.WriteLine("{0}", sueldoSemanal);
		}
		private double CobroPorHoras(double horasSemanal, double pagosPorHoras)
		{
			double sueldoSemanal = 0.0;
			double doble = 0.0;

			if (horasSemanal < 41)
			{
				sueldoSemanal = horasSemanal * pagosPorHoras;
			}
			else if(horasSemanal > 41 && horasSemanal < 45)
			{
				sueldoSemanal = horasSemanal * pagosPorHoras;
				doble = sueldoSemanal * 2;
				return doble;
			}
			else if (horasSemanal > 46 && horasSemanal < 45)
			{
				sueldoSemanal = horasSemanal * pagosPorHoras;
				doble = sueldoSemanal * 3;
				return doble;
			}
			return sueldoSemanal;

		}
	}
}
