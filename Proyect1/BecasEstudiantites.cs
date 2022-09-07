
namespace Proyect1
{
	public class BecasEstudiantites
	{
		public void becas()
		{
			int edad = 18;
			double promedio = 0;
			double becas;
			
			Console.WriteLine("Indique su edad");
			edad = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Indique su promedio");
			promedio = Convert.ToDouble(Console.ReadLine());

			if(edad >= 18)
			{
				Console.WriteLine("Su monto de la beca es:");
				becas = ObtenerBeca(edad, promedio);
				Console.WriteLine("{0}", becas);

			}			
			else if (edad <= 18)
			{
				Console.WriteLine("Su monto de la beca es:");
				becas = ObtenerBecas(edad, promedio);
				Console.WriteLine("{0}", becas);
			}							
		}

		private double ObtenerBeca(int edad, double promedio)
		{			
			if (edad >= 18 && promedio >= 9)		
				return 2000.00;			
			else if ( promedio >= 7.5 )
				return 1000.00;				
			else if ( promedio <= 7.5 && promedio >= 6)
				return 500.00;			
			return promedio;
		}

		private double ObtenerBecas(int edad, double promedio)
		{
			if (edad <= 18 && promedio >= 9)
				return 3000;
			else if (promedio >= 8 && promedio <= 9)
				return 200;
			else if (promedio <= 8 && promedio >= 6)
				return 100;
			else if (promedio <= 6)
				Console.WriteLine("Se le enviara una carta de invitacion");
			return 0;
		}
	}
}