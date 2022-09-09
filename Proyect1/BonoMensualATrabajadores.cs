using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class BonoMensualATrabajadores
	{
		public void BonoMensual()
		{
			int añosantiguedadTrabajando = 0;
			double sueldo = 0.0;
			double bonoPorAños = 0.0;
			double MontoTotal = 0.0;			
	
			Console.WriteLine("Indique años de antiguedad trabajando");
			añosantiguedadTrabajando = Convert.ToInt32(Console.ReadLine());

			bonoPorAños = BonoDeAntiguedadTrabajando(añosantiguedadTrabajando);			

			Console.WriteLine("Indique sueldo");
			sueldo = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Su monto de bono de sueldo es:");
			MontoTotal = BonoDesueldo(bonoPorAños, sueldo);
			Console.WriteLine("{0}", MontoTotal);

		}
		private double BonoDeAntiguedadTrabajando(double añosantiguedadTrabajando)
		{
			double bonoPorAños = 0.0;

			if (añosantiguedadTrabajando > 2 && añosantiguedadTrabajando < 5)
				bonoPorAños =  1.20;
			else if(añosantiguedadTrabajando > 5)
				bonoPorAños =  1.30;
			return bonoPorAños;	
		}
		private double BonoDesueldo(double bonoPorAños, double sueldo)
		{			
			double bono = 0.0;
			double MontoTotal = 0.0;

			if (sueldo < 1000)
			{
				bono = sueldo * 1.25;
				MontoTotal = bono * bonoPorAños;
			}							
			else if(sueldo > 1000 && sueldo <= 3500)
			{
				bono = sueldo * 1.15;
				MontoTotal = bono * bonoPorAños;
			}							
			else if(sueldo > 3500)
			{
				bono = sueldo * 1.10;
				MontoTotal = bono * bonoPorAños;
			}					
			return MontoTotal;
		}
	}
}
