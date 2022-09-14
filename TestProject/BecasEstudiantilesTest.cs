namespace TestProject
{
	using System.Text;
	using Proyect1;

	public class BecasEstudiantilesTest
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test(Description = "Cuando alumno es mayor de 18 y promedio es mayor o igual a 9 la beca debe ser 2000")]
		public void TestCase01()
		{
			var writer = new StringWriter();
			Console.SetOut(writer);

			var beca = new BecasEstudiantites();

			var textosEnPantalla = new List<string>
			{
				"Indique su edad",
				"Indique su promedio",
				"Su monto de la beca es 2000"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("18");
			stringBuilder.AppendLine("10");
			var valoresIngresados = new StringReader(stringBuilder.ToString());

			Console.SetIn(valoresIngresados);
			beca.ObtenerMontoBeca();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}

		[Test(Description = "Cuando alumno es mayor de 18 y promedio es mayor o igual a 7.5 y menor a 9 la beca debe ser 1000")]
		public void TestCase02()
		{
			var writer = new StringWriter();
			Console.SetOut(writer);

			var beca = new BecasEstudiantites();

			var textosEnPantalla = new List<string>
			{
				"Indique su edad",
				"Indique su promedio",
				"Su monto de la beca es 1000"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("18");
			stringBuilder.AppendLine("8");
			var valoresIngresados = new StringReader(stringBuilder.ToString());

			Console.SetIn(valoresIngresados);
			beca.ObtenerMontoBeca();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}

		[Test(Description = "Cuando alumno es mayor de 18 y promedio es mayor o igual a 6 y menor a 7.5 la beca debe ser 500")]
		public void TestCase03()
		{
			var writer = new StringWriter();
			Console.SetOut(writer);

			var beca = new BecasEstudiantites();

			var textosEnPantalla = new List<string>
			{
				"Indique su edad",
				"Indique su promedio",
				"Su monto de la beca es 500"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("18");
			stringBuilder.AppendLine("6");
			var valoresIngresados = new StringReader(stringBuilder.ToString());

			Console.SetIn(valoresIngresados);
			beca.ObtenerMontoBeca();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}

		[Test(Description = "Cuando alumno es mayor de 18 y promedio es menor a 6 la beca debe ser 0")]
		public void TestCase04()
		{
			var writer = new StringWriter();
			Console.SetOut(writer);

			var beca = new BecasEstudiantites();

			var textosEnPantalla = new List<string>
			{
				"Indique su edad",
				"Indique su promedio",
				"Le invitamos a estudiar mas para el siguiente año"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("18");
			stringBuilder.AppendLine("4");
			var valoresIngresados = new StringReader(stringBuilder.ToString());

			Console.SetIn(valoresIngresados);
			beca.ObtenerMontoBeca();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}
	}
}