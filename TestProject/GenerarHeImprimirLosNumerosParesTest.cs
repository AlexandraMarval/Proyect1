using Proyect1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class GenerarHeImprimirLosNumerosParesTest
	{
		[Test(Description = "Generar e imprimir los numeros pares que se encuentran entre 0 y 100")]
		public void TestCase01()
		{
			var numero = new GenerarHeImprimirLosNumerosPares();

			var impresionesPorPantallaEsperada = new List<string>
			{
				"Numero generado 0",
				"Numero generado 2",
				"Numero generado 4",
				"Numero generado 6",
				"Numero generado 8",
				"Numero generado 10",
				"Numero generado 12",
				"Numero generado 14",
				"Numero generado 16",
				"Numero generado 18",
				"Numero generado 20",
				"Numero generado 22",
				"Numero generado 24",
				"Numero generado 26",
				"Numero generado 28",
				"Numero generado 30",
				"Numero generado 32",
				"Numero generado 34",
				"Numero generado 36",
				"Numero generado 38",
				"Numero generado 40",
				"Numero generado 42",
				"Numero generado 44",
				"Numero generado 46",
				"Numero generado 48",
				"Numero generado 50",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			numero.NumerosPares();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallaEsperada));
		}
	}
}
