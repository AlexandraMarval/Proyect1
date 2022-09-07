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
			double monto = 0.0;
			double bonoPorAños = 0.0;
	
			Console.WriteLine("Indique años de antiguedad trabajando");
			añosantiguedadTrabajando = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Indique sueldo");
			sueldo = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Su bono de antiguedad es:");
			bonoPorAños = BonoDeAntiguedadTrabajando(añosantiguedadTrabajando);
			Console.WriteLine("{0}", bonoPorAños);

			Console.WriteLine("Su monto de bono de sueldo es:");
			monto = BonoDesueldo(sueldo);
			Console.WriteLine("{0}", monto);

		}
		private double BonoDeAntiguedadTrabajando(int añosantiguedadTrabajando)
		{
			double monto = 0.0;

			if (añosantiguedadTrabajando > 2 && añosantiguedadTrabajando < 5)			
				monto = añosantiguedadTrabajando * 1.20;			
			else if(añosantiguedadTrabajando > 5)		
				monto = añosantiguedadTrabajando * 1.30;	
			return monto;	
		}
		private double BonoDesueldo(double sueldo)
		{
			double monto = 0.0;

			if (sueldo < 1000)			
				monto = sueldo * 1.25;			
			else if(sueldo > 1000 && sueldo <= 3500)			
				monto = sueldo * 1.15;			
			else if(sueldo > 3500)			
				monto = sueldo * 1.10;		
			return monto;

		}


	}
}
