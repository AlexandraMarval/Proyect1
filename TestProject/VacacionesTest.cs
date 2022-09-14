namespace TestProject
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Proyect1;

	internal class VacacionesTest
	{
		[Test(Description = "Cuando vas a México y el costo por KM son 5$ debes pagar 7500")]
		public void TestCase01()
		{
			var writer = new StringWriter();
			Console.SetOut(writer);
			var resultadoEsperado = "El monto a pagar son 7500";

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("1");
			stringBuilder.AppendLine("5");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			var calculadoraVacaciones = new CalculadoraVacaciones();
			calculadoraVacaciones.Calcular();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
			var resultadoFinal = salidasEnPantalla.ElementAt(salidasEnPantalla.Length - 2);

			Assert.That(resultadoFinal, Is.EqualTo(resultadoEsperado));
		}

		[Test(Description = "Cuando vas a P.V. y el costo por KM son 8$ debes pagar 12800")]
		public void TestCase02()
		{
			var writer = new StringWriter();
			Console.SetOut(writer);
			var resultadoEsperado = "El monto a pagar son 12800";

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("2");
			stringBuilder.AppendLine("8");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			var calculadoraVacaciones = new CalculadoraVacaciones();
			calculadoraVacaciones.Calcular();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
			var resultadoFinal = salidasEnPantalla.ElementAt(salidasEnPantalla.Length - 2);

			Assert.That(resultadoFinal, Is.EqualTo(resultadoEsperado));
		}

		[Test(Description = "Cuando vas a Acapulco y el costo por KM son 7$ debes pagar 16800")]
		public void TestCase03()
		{
			var writer = new StringWriter();
			Console.SetOut(writer);
			var resultadoEsperado = "El monto a pagar son 16800";

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("3");
			stringBuilder.AppendLine("7");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			var calculadoraVacaciones = new CalculadoraVacaciones();
			calculadoraVacaciones.Calcular();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
			var resultadoFinal = salidasEnPantalla.ElementAt(salidasEnPantalla.Length - 2);

			Assert.That(resultadoFinal, Is.EqualTo(resultadoEsperado));
		}

		[Test(Description = "Cuando vas a Cancún y el costo por KM son 8$ debes pagar 28800")]
		public void TestCase04()
		{
			var writer = new StringWriter();
			Console.SetOut(writer);
			var resultadoEsperado = "El monto a pagar son 28800";

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("4");
			stringBuilder.AppendLine("8");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			var calculadoraVacaciones = new CalculadoraVacaciones();
			calculadoraVacaciones.Calcular();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
			var resultadoFinal = salidasEnPantalla.ElementAt(salidasEnPantalla.Length - 2);

			Assert.That(resultadoFinal, Is.EqualTo(resultadoEsperado));
		}
	}
}
