using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class ObtenerLaEdad
	{
		public void LaEdad()
		{
			string fechaDeNacimiento = "";
			int años = 0;

			Console.WriteLine("Indique su Fecha de Nacimiento");
			fechaDeNacimiento = Console.ReadLine();
			DateTime fechaDeNacimientodate = DateTime.ParseExact(fechaDeNacimiento, "dd/mm/yyyy", null);
			DateTime fechaActual = DateTime.Now;
			años = fechaActual.Year - fechaDeNacimientodate.Year;
			Console.WriteLine("Edad persona es {0}", años);
		}
	}
}
