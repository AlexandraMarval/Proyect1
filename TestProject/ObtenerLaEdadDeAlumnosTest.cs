namespace TestProject
{
	using System;
	using System.Text;
	using Proyect1;

	public class ObtenerLaEdadDeAlumnosTest
	{
		[Test(Description = "Se requiere obtener la edad promedio de un grupo de alumnos")]
		public void TestCase01()
		{
			var resultadoEsperadoPromedioEdades = 19.5;
			var impresionesPorPantallEsperadas = new List<string>
			{
				"Indique la cantidad de alumnos",
				"Indique la edad del alumno 1",
				"Indique la edad del alumno 2",
				"Indique la edad del alumno 3",
				"Indique la edad del alumno 4",
				$"El promedio de las edades de los alumnos es {resultadoEsperadoPromedioEdades}",
				""
			};

			var obtenerLaEdad = new ObtenerLaEdadDeAlumnos();

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("4");

			stringBuilder.AppendLine("8");
			stringBuilder.AppendLine("11");
			stringBuilder.AppendLine("27");
			stringBuilder.AppendLine("32");

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			obtenerLaEdad.ObtenerLaEdadDeNumeroDeAlumnos();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));

		}
	}
}
