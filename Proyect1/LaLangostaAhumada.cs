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
			double banqueteAcomprar;
			double tarifaPorPersona = 95.00;
			double tarifa1 = 85.00;
			double tarifa2 = 75.00;
			double cantidadPersona = 0.0;
			double cantidadPersonaMenor = 0.0;
			double cantidadPersonaMayor = 0.0;
			double costoTotalBanquete = 0.0;

			Console.WriteLine("Indique cantidad de personas");
			dato = Console.ReadLine();
			banqueteAcomprar = Convert.ToDouble(dato);

			if (banqueteAcomprar < 200)
			{
				cantidadPersona = banqueteAcomprar * tarifaPorPersona;

				costoTotalBanquete = cantidadPersona;

				Console.WriteLine("Costo total banquete es {0}", costoTotalBanquete);
			}
			else if(banqueteAcomprar < 300)
			{
				cantidadPersonaMenor = banqueteAcomprar * tarifa1;

				costoTotalBanquete = cantidadPersonaMenor;

				Console.WriteLine("Costo total banquete es {0}", costoTotalBanquete);
			}
			else if(banqueteAcomprar > 300)
			{
				cantidadPersonaMayor = banqueteAcomprar * tarifa2;

				costoTotalBanquete = cantidadPersonaMayor;

				Console.WriteLine("Costo total banquete es {0}", costoTotalBanquete);
			}			
		} 
	}				
}
