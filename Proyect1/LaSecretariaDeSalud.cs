using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class LaSecretariaDeSalud
	{
		
		public void SecretariaDeSalud()
		{									
			Console.WriteLine("Indique la edad");
			 var edad = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Indique el genero");
			 var genero = (Console.ReadLine());

			var tipoDeVacuna = TiposDeVacunaParaEdades(edad, genero);
			Console.WriteLine($"La vacuna correspondiente es: {tipoDeVacuna}");
		}

		private string TiposDeVacunaParaEdades( int edad, string genero)
		{			
			string vacuna = "";

			switch (edad)
			{
				case > 70:
					vacuna = "C";
					break;
				case > 16 and < 69:
					if (genero == "mujer")
						vacuna = "B";
					else if (genero == "hombre")
						vacuna = "A";
					break;
				case < 16:
					vacuna = "A";
					break;
			}
			return vacuna;		

		}
	}
}
