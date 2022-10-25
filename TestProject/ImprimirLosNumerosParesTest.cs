namespace TestProject
{
	using Proyect1;
	using System;
	using System.Text;

	public class ImprimirLosNumerosParesTest
	{
		[Test(Description = "Generar e imprimir los numeros pares")]
		public void TestCase02()
		{
			var numeros = new ImprimirLosNumerosPares();

			var impresionesPorPantallEsperadas = new string[]
			{
				"El número es 0",
				"El número es 2",
				"El número es 4",
				"El número es 6",
				"El número es 8",
				"El número es 10",
				"El número es 12",
				"El número es 14",
				"El número es 16",
				"El número es 18",
				"El número es 20",
				"El número es 22",
				"El número es 24",
				"El número es 26",
				"El número es 28",
				"El número es 30",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();			
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);
			numeros.NumerosPares();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));
		}
	}
}
