using Proyect1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class DeterminarCuantoAhorraraUnaPersonaEnUnAñoTest
	{
		[Test(Description = "Se requiere determinar cuanto ahorrará una persona en un año")]
		public void TestCase01()
		{
			var cantidad = new DeterminarCuantoAhorraraUnapersonaEnUnAño();

			var cantidadAhorradaEnUnAño = 516;

			var impresionesPorPantallEsperadas = new List<string>
			{
				"Indique cantidad que se va ahorrar: 1",
				"Para el mes de Enero tiene ahorrado 20.",
				"Indique cantidad que se va ahorrar: 2",
				"Para el mes de Febrero tiene ahorrado 80.",
				"Indique cantidad que se va ahorrar: 3",
				"Para el mes de Marzo tiene ahorrado 101.",
				"Indique cantidad que se va ahorrar: 4",
				"Para el mes de Abril tiene ahorrado 151.",
				"Indique cantidad que se va ahorrar: 5",
				"Para el mes de Mayo tiene ahorrado 171.",
				"Indique cantidad que se va ahorrar: 6",
				"Para el mes de Junio tiene ahorrado 196.",
				"Indique cantidad que se va ahorrar: 7",
				"Para el mes de Julio tiene ahorrado 206.",
				"Indique cantidad que se va ahorrar: 8",
				"Para el mes de Agosto tiene ahorrado 226.",
				"Indique cantidad que se va ahorrar: 9",
				"Para el mes de Septiembre tiene ahorrado 326.",
				"Indique cantidad que se va ahorrar: 10",
				"Para el mes de Octubre tiene ahorrado 346.",
				"Indique cantidad que se va ahorrar: 11",
				"Para el mes de Noviembre tiene ahorrado 366.",
				"Indique cantidad que se va ahorrar: 12",
				"Para el mes de Diciembre tiene ahorrado 516.",
				$"Cantidad Ahorrada en un año {cantidadAhorradaEnUnAño}",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("20");
			stringBuilder.AppendLine("60");
			stringBuilder.AppendLine("21");
			stringBuilder.AppendLine("50");
			stringBuilder.AppendLine("20");
			stringBuilder.AppendLine("25");
			stringBuilder.AppendLine("10");
			stringBuilder.AppendLine("20");
			stringBuilder.AppendLine("100");
			stringBuilder.AppendLine("20");
			stringBuilder.AppendLine("20");
			stringBuilder.AppendLine("150");


			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			cantidad.ObtenerCantidadDeUnaPersonaEnUnAño();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));

		}
	}
}
 