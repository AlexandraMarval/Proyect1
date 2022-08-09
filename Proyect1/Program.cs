
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
			Console.WriteLine("Indique que programa desea? 1 Calcular, 2 CalcularSueldoSemanal, 3 CobroPorHoras, 4 ConversionADolares, 5 ElHarapientoDistinguido, 6 LaBrochaGorda, 7 ObtenerGanancia, 8 ObtenerLaEdad, 9 OperacionesMatematicas ");
			dato = Console.ReadLine();
			opcion = Convert.ToInt32(dato);

			if (opcion == 1)
			{
				CalcularArea calcular = new CalcularArea();
				calcular.Calcular();
			}
			else if (opcion == 2)
			{
				CalcularSueldoSemanal calcular = new CalcularSueldoSemanal();
				calcular.SueldoSemanal();
			}
			else if(opcion == 3)
			{
				CobroPorHoras horas = new CobroPorHoras();
				horas.CobroHoras();
			}
			else if (opcion == 4)
			{
				ConversionADolares conversion = new ConversionADolares();
				conversion.ConversionDolares();
			}
			else if (opcion == 5)
			{
				ElHarapientoDistinguido tienda = new ElHarapientoDistinguido();
				tienda.ElHarapiento();
			}
			else if (opcion == 6)
			{
				LaBrochaGorda laBrocha = new LaBrochaGorda();
				laBrocha.LaGorda();
			}
			else if (opcion == 7)
			{
				ObtenerGanancia obtener = new ObtenerGanancia();
				obtener.Ganancia();
			}
			else if (opcion == 8)
			{
				ObtenerLaEdad obtener = new ObtenerLaEdad();
				obtener.LaEdad();
			}
			else if (opcion == 9)
			{
				OperacionesMatematicas operaciones = new OperacionesMatematicas();
				operaciones.Matematicas();
			}
		}	
	}
}