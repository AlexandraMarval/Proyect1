using System;

namespace Prueba_Curso
{
	public class Program
	{	
		public void PruebaCurso()
		{
			int? edad = null;

			Console.WriteLine("Valor por defecto de int: ");
			Console.WriteLine(edad);

			string nombre = null;

			Console.WriteLine("Valor por defecto de string: ");
			Console.WriteLine(nombre.ToUpper());
		}
	}
}
