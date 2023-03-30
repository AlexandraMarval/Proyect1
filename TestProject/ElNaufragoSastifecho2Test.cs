using Proyect1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class ElNaufragoSastifecho2Test
	{
		[Test(Description = "El Naufrago sastifecho 2")]
		public void TestCase01()
		{
			var opción = new ElNaufragoSastifecho2();

			var totalAPagar = 28;

			var impresionesPorPantallaEsperada = new List<string>
			{
				"¿Indique que tipos de hamburguesas desea? 1 Sencilla, 2 Doble, 3 Triple",
				"Indique cantidad de hamburguesas",
				"¿Indique que opción desea cancelar? 1 Efectivo, 2 Tarjeta",
				$"El Precio de su hamburguesa es: {totalAPagar}",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("3");

			stringBuilder.AppendLine("2");

			stringBuilder.AppendLine("1");

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			opción.HamburguesasNaufragoSatisfecho();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallaEsperada));
		}
	}
}
