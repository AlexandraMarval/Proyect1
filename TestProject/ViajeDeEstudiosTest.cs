using Proyect1;
using System;
namespace TestProject
{
	using Proyect1;
	using System.Text;

	public class ViajeDeEstudiosTest
	{
		[Test(Description = "Si son mas de 100 alunmo, el costo del pasaje es de 20$")]
		public void TestCase01()
		{
			var viaje = new ViajeDeEstudio();

			var writer = new StringWriter();
			Console.SetOut(writer);

			var textosEnPantalla = new List<string>
			{
				"Indique la cantidad de alumnos que asistiran",
				"El costo del pasaje son 20"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("100");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			viaje.Ejecutar();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}

		[Test(Description = "Si son entre 50 y 100, el costo del pasaje es de 35$")]
		public void TestCase02()
		{
			var viaje = new ViajeDeEstudio();

			var writer = new StringWriter();
			Console.SetOut(writer);

			var textosEnPantalla = new List<string>
			{
				"Indique la cantidad de alumnos que asistiran",
				"El costo del pasaje son 35"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("55");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			viaje.Ejecutar();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}

		[Test(Description = "Si son entre 20 y 49, el costo del pasaje es de 40$")]
		public void TestCase03()
		{
			var viaje = new ViajeDeEstudio();

			var writer = new StringWriter();
			Console.SetOut(writer);

			var textosEnPantalla = new List<string>
			{
				"Indique la cantidad de alumnos que asistiran",
				"El costo del pasaje son 40"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("30");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			viaje.Ejecutar();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}

		[Test(Description = "Si son menos de 20, el costo del pasaje es de 70$")]
		public void TestCase04()
		{
			var viaje = new ViajeDeEstudio();

			var writer = new StringWriter();
			Console.SetOut(writer);

			var textosEnPantalla = new List<string>
			{
				"Indique la cantidad de alumnos que asistiran",
				"El costo del pasaje son 70"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("12");
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			viaje.Ejecutar();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}
	}
}
