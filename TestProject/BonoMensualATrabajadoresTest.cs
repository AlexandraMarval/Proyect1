namespace TestProject
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Proyect1;

	public class BonoMensualATrabajadoresTest
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test(Description = "Cuando la antiguedad sea mayor a 2 y menor a 5 se otorga el 20 % del sueldo")]
		public void TestCase01()
		{
			var sueldo = 3500d;
			var sueldoConBonoPorAntiguedad = sueldo * 1.20;
			var sueldoConBonoPorSalario = sueldo * 1.15;
			var sueldoMayor = sueldoConBonoPorAntiguedad > sueldoConBonoPorSalario ? sueldoConBonoPorAntiguedad : sueldoConBonoPorSalario;

			/*
			if (sueldoConBonoPorAntiguedad > sueldoConBonoPorSalario)
			{
				sueldoMayor = sueldoConBonoPorAntiguedad;
			}
			else
			{
				sueldoMayor = sueldoConBonoPorSalario;
			}
			*/

			var writer = new StringWriter();
			Console.SetOut(writer);

			var calculadoraDeBono = new BonoMensualATrabajadores();

			var textosEnPantalla = new List<string>
			{
				"Indique los años de antiguedad trabajando",
				"Indique el sueldo",
				$"Su bono será de {sueldoMayor}"
			};

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("3");
			stringBuilder.AppendLine(sueldo.ToString());
			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			calculadoraDeBono.BonoMensual();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

			for (int i = 0; i < textosEnPantalla.Count; i++)
			{
				Assert.That(salidasEnPantalla[i], Is.EqualTo(textosEnPantalla[i]));
			}
		}
	}
}
