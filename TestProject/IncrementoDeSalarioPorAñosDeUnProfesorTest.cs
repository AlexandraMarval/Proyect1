using Proyect1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class IncrementoDeSalarioPorAñosDeUnProfesorTest
	{
		[Test(Description = " Un profesor tiene un salario inicial 1.500 y recibe un incremento de 10% anual durante 6 años")]
		public void TestCase01()
		{
			var salario = new IncrementoDeSalarioPorAñosDeUnProfesor();

			var sueldoEsperado = 2657;

			var impresionesPorPantallEsperadas = new List<string>
			{
				"Indique salario inicial",				
				"Aumento de su salario por 1 es 1650",
				"Aumento de su salario por 2 es 1815",
				"Aumento de su salario por 3 es 1996",
				"Aumento de su salario por 4 es 2196",
				"Aumento de su salario por 5 es 2415",
				"Aumento de su salario por 6 es 2657",
				$"Sueldo total al cabo es {sueldoEsperado}",		
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("1500");

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			salario.IncrementoDeSalarioPorAños();
			
			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));
		}
	}	
}
