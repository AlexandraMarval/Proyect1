namespace Proyect1
{
	public class LaLangostaAhumada
	{
		public void CalcularPrecioBanquete()
		{
			Console.WriteLine("Indique cantidad de personas");
			var dato = Console.ReadLine();
			var cantidadPersonas = Convert.ToInt32(dato);

			var precioPlato = DeterminarPrecioPorPlato(cantidadPersonas);
			var costoTotalBanquete = cantidadPersonas * precioPlato;

			Console.WriteLine("Costo total banquete es {0}", costoTotalBanquete);
		}

		private double DeterminarPrecioPorPlato(int cantidadPersonas)
		{
			double precioPlato = 0.0;

			if (cantidadPersonas < 200)
				precioPlato = 95.00;
			else if (cantidadPersonas < 300)
				precioPlato = 85.00;
			else if (cantidadPersonas > 300)
				precioPlato = 75;

			return precioPlato;
		}
	}				
}
