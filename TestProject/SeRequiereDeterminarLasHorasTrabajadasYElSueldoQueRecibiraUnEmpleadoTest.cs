using Proyect1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class SeRequiereDeterminarLasHorasTrabajadasYElSueldoQueRecibiraUnEmpleadoTest
	{
		[Test(Description = "Se requiere determinar las horas trabajadas por un empleado, asi como el sueldo que recibira por las horas trabajadas")]
		public void TestCase01()
		{
			var horasYSueldoDeUnEmpleado = new SeRequiereDeterminarLasHorasTrabajadasYElSueldoQueRecibiraUnEmpleado();

			var horasTrabajadasEnLaSemana = 48;
			double SueldoSemanal = 1920;

			var impresionesPorPantallEsperadas = new List<string>
			{
				"Pagos por horas",
				"Dia lunes 1",
				"Dia martes 2",
				"Dia miércoles 3",
				"Dia jueves 4",
				"Dia viernes 5",
				"Dia sábado 6",
				$"Horas trabajadas por {horasTrabajadasEnLaSemana} && {SueldoSemanal}",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("40");

			stringBuilder.AppendLine("8");
			stringBuilder.AppendLine("9");
			stringBuilder.AppendLine("5");
			stringBuilder.AppendLine("7");
			stringBuilder.AppendLine("9");
			stringBuilder.AppendLine("10");

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			horasYSueldoDeUnEmpleado.DeterminarLAsHorasTrabajadasYElsueldoQueRecibiraUnEmpleado();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));

		}


		[Test(Description = "Se requiere determinar las horas trabajadas por un empleado, asi como el sueldo que recibira por las horas trabajadas")]
		public void TestCase02()
		{
			var horasYSueldoDeUnEmpleado = new SeRequiereDeterminarLasHorasTrabajadasYElSueldoQueRecibiraUnEmpleado();

			var horasTrabajadasEnLaSemana = 6;
			var SueldoSemanal = 24;

			var impresionesPorPantallEsperadas = new List<string>
			{
				"Pagos por horas",
				"Dia lunes 1",
				"Dia martes 2",
				"Dia miércoles 3",
				"Dia jueves 4",
				"Dia viernes 5",
				"Dia sábado 6",
				$"Horas trabajadas por {horasTrabajadasEnLaSemana} && {SueldoSemanal}",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("4");

			stringBuilder.AppendLine("1");
			stringBuilder.AppendLine("1");
			stringBuilder.AppendLine("1");
			stringBuilder.AppendLine("1");
			stringBuilder.AppendLine("1");
			stringBuilder.AppendLine("1");

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			horasYSueldoDeUnEmpleado.DeterminarLAsHorasTrabajadasYElsueldoQueRecibiraUnEmpleado();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));

		}
	}
}
