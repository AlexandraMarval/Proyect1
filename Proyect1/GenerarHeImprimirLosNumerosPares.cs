namespace Proyect1
{
	public class GenerarHeImprimirLosNumerosPares
	{
		public void NumerosParesWhile()
		{
			int numero = 0;

			while(numero <= 50)
			{
				Console.WriteLine($"Numero generado {numero}");

				numero = numero + 2;
			}
		}
		
		public void NumerosParesOperadorMod()
		{
			for (int i = 0; i <= 50; i++)
			{
				var resultado = i % 2;
				if (resultado == 0)
					Console.WriteLine($"Numero generado {i}");
			}
		}
		
		public void NumerosPares()
		{
			for (int i = 0; i <= 50; i += 2)
				Console.WriteLine($"Numero generado {i}");
		}
	}
}
