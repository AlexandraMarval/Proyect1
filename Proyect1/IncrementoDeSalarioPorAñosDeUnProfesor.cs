using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class IncrementoDeSalarioPorAñosDeUnProfesor
	{
		public void IncrementoDeSalarioPorAños()
		{
			double sueldo;
			double incrementoPorAño;
			double SueldoActualPorAumeto;
			double sueldoEsperado = 0;
			double sueldoEsperadoAhora = 0;

			Console.WriteLine($"Indique salario inicial");
			sueldo = Convert.ToDouble(Console.ReadLine());

			for ( int años = 1; años <= 6; años++)
			{
				sueldo = CalcularSueldoPorIncremento(sueldo);
				
				Console.WriteLine($"Aumento de su salario por {años} es {Math.Floor(sueldo)}");
			}
			Console.WriteLine($"Sueldo total al cabo es {Math.Floor(sueldo)}");
		}
		private double CalcularSueldoPorIncremento(double sueldoInicial)
		{		
			return sueldoInicial * 1.10;
		}

	}
}
