namespace TestProject
{
	using Proyect1;
	using System;
	using System.Text;

	public class ObtenerLaSumaDeDiezCantidadesTest
	{
		[Test(Description = "Obtener la suma de diez cantidades")]
		public void TestCase03()
		{
			var suma = new ObtenerLaSumaDeDiezCantidades();

			var sumaEsperada = 54;
			var impresionesPorPantallEsperadas = new List<string>
			{				
				"Indique el numero a sumar: 1",
				"Indique el numero a sumar: 2",
				"Indique el numero a sumar: 3",
				"Indique el numero a sumar: 4",
				"Indique el numero a sumar: 5",
				"Indique el numero a sumar: 6",
				"Indique el numero a sumar: 7",
				"Indique el numero a sumar: 8",
				"Indique el numero a sumar: 9",
				"Indique el numero a sumar: 10",
				$"resultado de la suma: {sumaEsperada}",
				""
			};
			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();

			stringBuilder.AppendLine("4");
			stringBuilder.AppendLine("6");
			stringBuilder.AppendLine("9");
			stringBuilder.AppendLine("2");
			stringBuilder.AppendLine("7");
			stringBuilder.AppendLine("6");
			stringBuilder.AppendLine("1");
			stringBuilder.AppendLine("8");
			stringBuilder.AppendLine("3");
			stringBuilder.AppendLine("8");

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			suma.SumaDeDiezCantidades();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));
		}
	}
}
