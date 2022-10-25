
using System.Text;

namespace Proyect1
{
	public class ObtenerLaEdadDeAlumnos
	{
		public void ObtenerLaEdadDeNumeroDeAlumnos()
		{
			int numeroDeAlumnos;
			var acumuladoDeEdades = 0;
			int edadDelAlumno = 0;

			Console.WriteLine("Indique la cantidad de alumnos");
			numeroDeAlumnos = Convert.ToInt32(Console.ReadLine());

			for (int c = 1; c <= numeroDeAlumnos; c++)
			{				
				Console.WriteLine($"Indique la edad del alumno {c}");
				edadDelAlumno = Convert.ToInt32(Console.ReadLine());
				acumuladoDeEdades = acumuladoDeEdades + edadDelAlumno;
			}

			var promedioDeEdades = CalcularPromedio(acumuladoDeEdades, numeroDeAlumnos);

			Console.WriteLine($"El promedio de las edades de los alumnos es {promedioDeEdades}");
		}

		private double CalcularPromedio(int acumulado, int numeroAlumnos)
		{
			return (double) acumulado / numeroAlumnos;
		}
	}		
	
}
