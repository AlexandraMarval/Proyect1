using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class ObtenerLaSumaDeDiezCantidades
	{
		public void SumaDeDiezCantidades()
		{
			double suma = 0;
			int contador;
			double valor = 0;
		

			for ( contador = 1; contador <= 10; contador++)
			{								
				Console.WriteLine($"Indique el numero a sumar: {contador}");
				valor = Convert.ToInt32(Console.ReadLine());
				suma = suma + valor;
			}
			Console.WriteLine($"resultado de la suma: {suma}");
		}
		
				
	}
}
