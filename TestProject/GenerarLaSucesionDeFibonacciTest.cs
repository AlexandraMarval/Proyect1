using Proyect1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class GenerarLaSucesionDeFibonacciTest
	{
		[Test(Description = "Generar e imprimir los numeros pares que se encuentran entre 0 y 100")]
		public void TestCase01()
		{
			var generar = new GenerarLaSucesionDeFibonacci();

			var impresionesPorPantallaEsperada = new List<string>
			{
				$"Se imprime los dos numeros 01",
				"indique el numero",
				"Imprime 1",
				"Imprime 2",
				"Imprime 3",
				"Imprime 5",
				"Imprime 8",
				"Imprime 13",
				"Imprime 21",
				"Imprime 34",
				"Imprime 55",
				"Imprime 89",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("12");

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			generar.SucesionDeFibonacci();
			
			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallaEsperada));
		}

	}
}
