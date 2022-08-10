
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class Program
	{
		private static void Main(string[] args)
		{			
			string dato;
			int opcion = 0;
			Console.WriteLine("Indique que programa desea? 1 Calcular, 2 CalcularSueldoSemanal, 3 CobroPorHoras, 4 ConversionADolares, 5 ElHarapientoDistinguido, 6 LaBrochaGorda, 7 ObtenerGanancia, 8 ObtenerLaEdad, 9 OperacionesMatematicas, 10 La langosta ahumada ");
			dato = Console.ReadLine();
			opcion = Convert.ToInt32(dato);

			switch (opcion)
			{
				case 1:
					CalcularArea calcular = new CalcularArea();
					calcular.Calcular();
					break;

				case 2:
					CalcularSueldoSemanal sueldoSemanal = new CalcularSueldoSemanal();
					sueldoSemanal.SueldoSemanal();
					break;

				case 3:
					CobroPorHoras horas = new CobroPorHoras();
					horas.CobroHoras();
					break;

				case 4:
					ConversionADolares conversion = new ConversionADolares();
					conversion.ConversionDolares();
					break;

				case 5:
					ElHarapientoDistinguido tienda = new ElHarapientoDistinguido();
					tienda.ElHarapiento();
					break;

				case 6:
					LaBrochaGorda laBrocha = new LaBrochaGorda();
					laBrocha.LaGorda();
					break;

				case 7:
					ObtenerGanancia obtener = new ObtenerGanancia();
					obtener.Ganancia();
					break;

				case 8:
					ObtenerLaEdad edad = new ObtenerLaEdad();
					edad.LaEdad();
					break;

				case 9:
					OperacionesMatematicas operaciones = new OperacionesMatematicas();
					operaciones.Matematicas();
					break;

				case 10:
					LaLangostaAhumada laLangosta = new LaLangostaAhumada();
					laLangosta.LangostaAhumada();
					break;
			}			
		}
	}
}