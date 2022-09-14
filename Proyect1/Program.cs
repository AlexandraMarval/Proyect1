
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
			Console.WriteLine("Indique que programa desea? $1 Calcular, $2 CalcularSueldoSemanal, 3 CobroPorHoras, 4 ConversionADolares, 5 ElHarapientoDistinguido, 6 LaBrochaGorda, 7 ObtenerGanancia, 8 ObtenerLaEdad, 9 OperacionesMatematicas, 10 La langosta ahumada, 11 Mayor y menor, 12 El naufrago satisfecho, 13 El cometa, 14 Becas estudiantiles, 15 Bono mensuales de trabajadores, 16 compañia de seguros, 17 Bono para empleados de una tienda, 18 determinar sueldo semanal ");
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
					laLangosta.CalcularPrecioBanquete();
					break;
				case 11:
					MayorYMenor mayorMenor = new MayorYMenor();
					mayorMenor.MayorYMenorDeTresNumeros();
					break;
				case 12:
					ElNaufragoSatisfecho satisfecho = new ElNaufragoSatisfecho();
					satisfecho.Ejecutar();
					break;
				case 13:
					ElCometa cometa = new ElCometa();
					cometa.Cometa();
					break;
				case 14:
					BecasEstudiantites estudiantes = new BecasEstudiantites();
					estudiantes.becas();
					break;
				case 15:
					BonoMensualATrabajadores bono = new BonoMensualATrabajadores();
					bono.BonoMensual();
					break;
				case 16:
					CompañiaDeSeguros compañia = new CompañiaDeSeguros();
					compañia.compañia();
					break;
				case 17:
					BonoParaTienda bono1 = new BonoParaTienda();
					bono1.BonoTienda();
					break;
				case 18:
					DeterminarSueldoSemanal sueldoSemanal1 = new DeterminarSueldoSemanal();
					sueldoSemanal1.SueldoSemanal();
					break;

			}			
		}
	}
}