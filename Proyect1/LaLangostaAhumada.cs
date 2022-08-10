using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class LaLangostaAhumada
	{
		public void LangostaAhumada()
		{
			string dato;
			double cantidadPersonas;
			double precioPlato = 0.0;
			double costoTotalBanquete = 0.0;

			Console.WriteLine("Indique cantidad de personas");
			dato = Console.ReadLine();
			cantidadPersonas = Convert.ToDouble(dato);

			if (cantidadPersonas < 200)
			{
				precioPlato = 95.00;
			}
			else if (cantidadPersonas < 300)
			{
				precioPlato = 85.00;
			}
			else if (cantidadPersonas > 300)
			{
				precioPlato = 75;
			}

			costoTotalBanquete = cantidadPersonas * precioPlato;

			Console.WriteLine("Costo total banquete es {0}", costoTotalBanquete);
		} 
	}				
}
