using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class DeterminarCuantoAhorraraUnapersonaEnUnAño
	{
		
		public void ObtenerCantidadDeUnaPersonaEnUnAño()
		{
			double ahorroMensual = 0.0;
			int cantidadAhorrada;
			int totalMeses = 12;

			for (int mes = 1; mes <= totalMeses; mes++)
			{
				Console.WriteLine($"Indique cantidad que se va ahorrar: {mes}");
				cantidadAhorrada = Convert.ToInt32(Console.ReadLine());

				ahorroMensual = ahorroMensual + cantidadAhorrada;
				var nombreMes = ObtenerNombreMesNumero(mes);

				Console.WriteLine($"Para el mes de {nombreMes} tiene ahorrado {ahorroMensual}.");
			}

			Console.WriteLine($"Cantidad Ahorrada en un año {ahorroMensual}");
		}

		private string ObtenerNombreMesNumero(int numeroMes)
		{
			var culture = new CultureInfo("es-ES");
			TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
			string nombreMes = culture.DateTimeFormat.GetMonthName(numeroMes);
			return ti.ToTitleCase(nombreMes);
		}
	}
}
