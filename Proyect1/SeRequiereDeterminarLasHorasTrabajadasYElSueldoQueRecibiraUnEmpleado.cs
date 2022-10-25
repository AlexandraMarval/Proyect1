using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class SeRequiereDeterminarLasHorasTrabajadasYElSueldoQueRecibiraUnEmpleado
	{
		public void DeterminarLAsHorasTrabajadasYElsueldoQueRecibiraUnEmpleado()
		{
			int pagoPorHoras;
			int horasTrabajadasEnLaSemana = 0;
			int horasTrabajadasPorDia;					

			Console.WriteLine("Pagos por horas");
			pagoPorHoras = Convert.ToInt32(Console.ReadLine());

			for (int dias = 1; dias <= 6; dias++)
			{
				var nombreDia = ObtenerNombredias(dias);

				Console.WriteLine($"Dia {nombreDia} {dias}");
				horasTrabajadasPorDia = Convert.ToInt32(Console.ReadLine());

				horasTrabajadasEnLaSemana = horasTrabajadasEnLaSemana + horasTrabajadasPorDia;	
			}
			var sueldoEsperado = CalcularSueldo(horasTrabajadasEnLaSemana, pagoPorHoras);

			Console.WriteLine($"Horas trabajadas por {horasTrabajadasEnLaSemana} && {sueldoEsperado}");
		}

		private double CalcularSueldo(int horasTrabajasEnLaSemana, int pagoPorHoras)
		{
			double SueldoSemanal;

		   return SueldoSemanal = horasTrabajasEnLaSemana * pagoPorHoras;
		}

		private string ObtenerNombredias(int numeroDias)
		{
			var culture = new CultureInfo("es-ES");			
			string nombredias = culture.DateTimeFormat.GetDayName((DayOfWeek) numeroDias);
			return nombredias;
		}
	}  
}
