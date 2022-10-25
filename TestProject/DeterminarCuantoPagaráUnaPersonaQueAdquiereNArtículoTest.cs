using Proyect1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class DeterminarCuantoPagaráUnaPersonaQueAdquiereNArtículoTest
	{
		[Test(Description = "Determinar cuanto pagara una persona que adquiere N artículo")]
		public void TestCase01()
		{
			var descuento = new DeterminarCuantoPagaráUnaPersonaQueAdquiereNArtículo();

			var impresionesPorPantallEsperadas = new List<string>
			{
				"Indique el precio del artículo 1",
				"Se le dará un DCTO de 45 €",
				"El artículo costará 255 €",
				"¿Desea comprar otro artículo?",
				"Usted adquirió 1 artículos",
				"El precio de los artículos es de 300 €",
				"El descuento será de 45 €",
				"El total a pagar serán 255 €",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("300");
			stringBuilder.AppendLine("NO");

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			descuento.CuantoPagaraUnaPersonaPorNArtículo();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));
		}

		[Test(Description = "Determinar cuanto pagara una persona que adquiere N artículo")]
		public void TestCase02()
		{
			var descuento = new DeterminarCuantoPagaráUnaPersonaQueAdquiereNArtículo();

			var impresionesPorPantallEsperadas = new List<string>
			{
				"Indique el precio del artículo 1",
				"Se le dará un DCTO de 45 €",
				"El artículo costará 255 €",
				"¿Desea comprar otro artículo?",
				"Indique el precio del artículo 2",
				"Se le dará un DCTO de 9 €",
				"El artículo costará 81 €",
				"¿Desea comprar otro artículo?",
				"Usted adquirió 2 artículos",
				"El precio de los artículos es de 390 €",
				"El descuento será de 54 €",
				"El total a pagar serán 336 €",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("300");
			stringBuilder.AppendLine("Si");
			stringBuilder.AppendLine("90");
			stringBuilder.AppendLine("NO");

			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			descuento.CuantoPagaraUnaPersonaPorNArtículo();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));
		}

		[Test(Description = "Determinar cuanto pagara una persona que adquiere N artículo")]
		public void TestCase03()
		{
			var descuento = new DeterminarCuantoPagaráUnaPersonaQueAdquiereNArtículo();

			var impresionesPorPantallEsperadas = new List<string>
			{
				"Indique el precio del artículo 1",
				"Se le dará un DCTO de 45 €",
				"El artículo costará 255 €",
				"¿Desea comprar otro artículo?",
				"Indique el precio del artículo 2",
				"Se le dará un DCTO de 9 €",
				"El artículo costará 81 €",
				"¿Desea comprar otro artículo?",
				"Indique el precio del artículo 3",
				"Se le dará un DCTO de 33 €",
				"El artículo costará 187 €",
				"¿Desea comprar otro artículo?",
				"Indique el precio del artículo 4",
				"Se le dará un DCTO de 10 €",
				"El artículo costará 90 €",
				"¿Desea comprar otro artículo?",
				"Indique el precio del artículo 5",
				"Se le dará un DCTO de 5 €",
				"El artículo costará 45 €",
				"¿Desea comprar otro artículo?",
				"Indique el precio del artículo 6",
				"Se le dará un DCTO de 18 €",
				"El artículo costará 132 €",
				"¿Desea comprar otro artículo?",
				"Usted adquirió 6 artículos",
				"El precio de los artículos es de 910 €",
				"El descuento será de 120 €",
				"El total a pagar serán 790 €",
				""
			};

			var writer = new StringWriter();
			Console.SetOut(writer);

			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("300"); //45  255
			stringBuilder.AppendLine("Si");
			stringBuilder.AppendLine("90"); //9  81
			stringBuilder.AppendLine("Si");
			stringBuilder.AppendLine("220"); //33  187
			stringBuilder.AppendLine("Si");
			stringBuilder.AppendLine("100"); //10  90
			stringBuilder.AppendLine("Si");
			stringBuilder.AppendLine("50"); //5  45
			stringBuilder.AppendLine("Si");
			stringBuilder.AppendLine("150"); //18  132
			stringBuilder.AppendLine("No");


			var valoresIngresados = new StringReader(stringBuilder.ToString());
			Console.SetIn(valoresIngresados);

			descuento.CuantoPagaraUnaPersonaPorNArtículo();

			var sb = writer.GetStringBuilder();
			var salidasEnPantalla = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries).ToList();

			Assert.That(salidasEnPantalla, Is.EqualTo(impresionesPorPantallEsperadas));
		}
	}
}

