using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class GenerarLaSucesionDeFibonacci
	{
		public void SucesionDeFibonacci()
		{
			int a = 0;
			int b = 1;
			int valorGenerado;
			double contadorDelCiclo = 1;
			int numero;

			Console.WriteLine($"Se imprime los dos numeros {a}{b}");

			Console.WriteLine("indique el numero");
			numero =  Convert.ToInt32(Console.ReadLine());

			while(contadorDelCiclo <= numero - 2)
			{
				valorGenerado = a + b;
				Console.WriteLine($"Imprime {valorGenerado}");
				a = b;
				b = valorGenerado;
				contadorDelCiclo++;
			}
		}
	}
}
