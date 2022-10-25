
namespace TestProject
{
	using Proyect1;
	using System.Text;

	public class LaSecretariaDeSaludTest
	{
		[Test(Description = "Tipo de vacuna se debe aplicar a una persona, considerando si es mayor a de 70 años, se le aplica la C ")]
		public void TestCase01()
		{
			var secretaria = new LaSecretariaDeSalud();

			var writer = new StringWriter();
			Console.SetOut(writer);

			var textosEnPantalla = new List<string>
			{
				"Indique la edad",
				"Indique el genero",
				"La vacuna correspondiente es: C"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("75");
			stringBuilder.AppendLine("genero");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			secretaria.SecretariaDeSalud();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}

		}

		[Test(Description = "Si tiene entre 16 y 69 años, y es mujer se le aplica la B")]
		public void TestCase02()
		{
			var secretaria = new LaSecretariaDeSalud();

			var writer = new StringWriter();
			Console.SetOut(writer);

			var textosEnPantalla = new List<string>
			{
				"Indique la edad",
				"Indique el genero",
				"La vacuna correspondiente es: B"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("40");
			stringBuilder.AppendLine("mujer");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			secretaria.SecretariaDeSalud();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		
		}

		[Test(Description = "Si tiene entre 16 y 69 años, y es hombre se le aplica la A ")]
		public void TestCase03()
		{
			var secretaria = new LaSecretariaDeSalud();

			var writer = new StringWriter();
			Console.SetOut(writer);

			var textosEnPantalla = new List<string>
			{
				"Indique la edad",
				"Indique el genero",
				"La vacuna correspondiente es: A"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("40");
			stringBuilder.AppendLine("hombre");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			secretaria.SecretariaDeSalud();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}

		[Test(Description = "Si es menor a 16 años, se le aplica la A")]
		public void TestCase04()
		{
			var secretaria = new LaSecretariaDeSalud();

			var writer = new StringWriter();
			Console.SetOut(writer);

			var textosEnPantalla = new List<string>
			{
				"Indique la edad",
				"Indique el genero",
				"La vacuna correspondiente es: A"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("15");			
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			secretaria.SecretariaDeSalud();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}

	}
}
