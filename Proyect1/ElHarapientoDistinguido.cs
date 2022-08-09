using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect1
{
	public class ElHarapientoDistinguido
	{
		public void ElHarapiento()
		{
			string datos;
			double trajeAcomprar;
			double trajePrecioAlto;
			double descuento = 15;
			double trajePrecioBajo = 0.0;
			int descuentos = 8;
			double montoApagar = 0.0;

			Console.WriteLine("Por favor indique el monto del traje que desea comprar");
			datos = Console.ReadLine();
			trajeAcomprar = Convert.ToDouble(datos);

			if (trajeAcomprar > 2500)
			{
				trajePrecioAlto = trajeAcomprar * descuento / 100;

				montoApagar = trajeAcomprar - trajePrecioAlto;

				Console.WriteLine("Total a pagar es {0}", montoApagar);
			}
			else if (trajeAcomprar < 2500)
			{
				trajePrecioBajo = trajeAcomprar * descuentos / 100;

				montoApagar = trajeAcomprar - trajePrecioBajo;

				Console.WriteLine("Total a pagar es {0}", montoApagar);
			}
		}
	}
}
