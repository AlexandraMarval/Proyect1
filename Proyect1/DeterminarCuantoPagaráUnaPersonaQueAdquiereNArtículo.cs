namespace Proyect1
{
	public class DeterminarCuantoPagaráUnaPersonaQueAdquiereNArtículo
	{
		public void CuantoPagaraUnaPersonaPorNArtículo()
		{
			bool continuar = true;
			int numArticulo = 0;
			double precioTotalArticulos = 0;
			double precioTotal = 0;
			double descuentoTotal = 0;

			do
			{
				double precioConDescuento = 0;

				numArticulo++;
				Console.WriteLine($"Indique el precio del artículo {numArticulo}");
				var precioArticulo = Convert.ToDouble(Console.ReadLine());
				precioTotalArticulos += precioArticulo;

				if (precioArticulo >= 200)
					precioConDescuento = precioArticulo * 0.15;
				else if (precioArticulo > 100 && precioArticulo < 200)
					precioConDescuento = precioArticulo * 0.12;
				else if (precioArticulo <= 100)
					precioConDescuento = precioArticulo * 0.10;

				descuentoTotal += precioConDescuento;
				double precioConDescuentoArticulo = precioArticulo - precioConDescuento;

				precioTotal += precioConDescuentoArticulo;

				Console.WriteLine($"Se le dará un DCTO de {Math.Round(precioConDescuento, 2)} €");
				Console.WriteLine($"El artículo costará {precioConDescuentoArticulo} €");
				Console.WriteLine("¿Desea comprar otro artículo?");
				var respuesta = Console.ReadLine();
				if (respuesta == "Si")
					continuar = true;
				else
					continuar = false;

			} while (continuar);

			Console.WriteLine($"Usted adquirió {numArticulo} artículos");
			Console.WriteLine($"El precio de los artículos es de {precioTotalArticulos} €");
			Console.WriteLine($"El descuento será de {descuentoTotal} €");
			Console.WriteLine($"El total a pagar serán {precioTotal} €");
		}
	}
}

