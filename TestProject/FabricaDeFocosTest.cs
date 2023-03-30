using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class FabricaDeFocosTest
	{
		[Test(Description = "Frabricas de focos de colores (Verde, Blanco y Rojos)")]
		public void TestCase01()
		{
			var impresionesPorPantallaEsperada = new List<string>
			{
				"Indique cantidad de focos",
				"Indique el color Verde Se hicieron 25",
				"1",
				"2",
				"3",
				"4",
				"5",
				"Indique el color Verde Se hicieron 30",
				"Indique el color Verde Se hicieron 15",				
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("3");
			

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);
		
			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallaEsperada));
		}
	}
}
