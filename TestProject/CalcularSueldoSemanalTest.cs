
namespace TestProject
{
	using System.Text;
	using Proyect1;

	public class CalcularSueldoSemanalTest
	{

		[SetUp]
		public void Setup()
		{
		}

		[Test(Description = "Calcular el sueldo semanal")]
		public void TestCase01()
		{
			var writer = new StringWriter();
			Console.SetOut(writer);

			var sueldo = new CalcularSueldoSemanal();

			var textosEnPantalla = new List<string>
			{
				"Cuantas horas a la semana trabaja",
				"Cuanto dinero recibe por hora",
				"El sueldo es 140"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("35");
			stringBuilder.AppendLine("4");
			var valoresIngresados = new StringReader(stringBuilder.ToString());

			Console.SetIn(valoresIngresados);
			sueldo.SueldoSemanal();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}
	}
}
