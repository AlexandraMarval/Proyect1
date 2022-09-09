using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class CompañiaDeSeguros
	{
		public void compañia()
		{
			string tiposDePolizas;					
			double MontoDePolizas;			

			Console.WriteLine("Indique tipo de poliza");
			tiposDePolizas = Console.ReadLine();
						
			MontoDePolizas = Polizas(tiposDePolizas);
			Console.WriteLine("{0}", MontoDePolizas);
		}

		private double Polizas(string tiposDePolizas)
		{
			string a = "a";
			string b = "b";
			string si = "si";
			string no = "no";
			int edad;
			double monto = 0.0;
			string enfermedad;							

			if (tiposDePolizas == a)
			{
				Console.WriteLine("edad");
				edad = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("¿Sufre de alguna enfermedad o tiene alguna adiccion?");
				enfermedad = Console.ReadLine();
				
				if (enfermedad == si && edad <= 40)			
					monto = 1200 * 1.5;				
				else if(enfermedad == no)				
					monto = 1200 * 1.10;
				else if (edad >= 40)
					monto = 1200 * 1.20;
			}
			else if(tiposDePolizas == b)
			{
				Console.WriteLine("edad");
				edad = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("¿Sufre de alguna enfermedad o tiene alguna adiccion?");
				enfermedad = Console.ReadLine();
				
				if (enfermedad == si && edad <= 40)				
					monto = 950 * 1.5;				
				else if (enfermedad == no)
					monto = 950 * 1.10;
				else if (edad >= 40)				
					monto = 950 * 1.20;				
			}
			return monto;
		}
	}
}
