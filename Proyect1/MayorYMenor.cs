using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class MayorYMenor
	{
		public void MayorYMenorDeTresNumeros()
		{
			string dato;
			int numero1 = 0;
			int numero2 = 0;
			int numero3 = 0;
			int igual = 0;
			
			Console.WriteLine("Valor 1");
			dato = Console.ReadLine();
			numero1 = Convert.ToInt32(dato);

			Console.WriteLine("Valor 2");
			dato = Console.ReadLine();
			numero2 = Convert.ToInt32(dato);

			Console.WriteLine("Valor 3");
			dato = Console.ReadLine();
			numero3 = Convert.ToInt32(dato);

			if (numero1 > numero2 & numero1 > numero3)			
				Console.WriteLine("El valor mayor es el primero {0}", numero1);		
			else if (numero2 > numero1 & numero2 > numero3)		
				Console.WriteLine("El valor mayor es el segundo {0}", numero2);			
			else if (numero3 > numero1 & numero3 > numero2)
				Console.WriteLine("El valor mayor es el tercer numero {0}", numero3);		
			else if (numero1 == numero2 && numero1 == numero3)		
				Console.WriteLine("los valores son iguales",igual);
			
		}
	}
}
