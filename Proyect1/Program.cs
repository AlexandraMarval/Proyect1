// See https://aka.ms/new-console-template for more information


int opciones = 0;
Console.WriteLine("Que programa desea ejecutar: \n1 calcular Area\n2 Operaciones Matematicas\n3 Obtener Ganancia\n4 Calcular sueldo semanal");
opciones = Convert.ToInt32(Console.ReadLine());

if (opciones == 1)
{
	CalcularArea();
}
else if (opciones == 2)
{
	OperacionesMatematicas();
}
else if (opciones == 3)
{
	ObtenerGanacia();
} 
else if (opciones == 4)
{
	CalcularSueldoSemanal();
}

void CalcularArea()
{
	double Area = 0.0;
	double altura = 0.0;
	double largo = 0.0;
	string dato = "";


	Console.WriteLine("Indique la altura");
	dato = Console.ReadLine();
	altura = Convert.ToDouble(dato);



	Console.WriteLine("Indique el largo");
	dato = Console.ReadLine();
	largo = Convert.ToDouble(dato);

	Area = altura * largo;

	Console.WriteLine("El resultado del Area es {0}", Area);
}

void OperacionesMatematicas()
{
	int primer = 0;
	int segundo = 0;
	string dat = "";
	int opcion = 0;
	int resultado = 0;

	Console.WriteLine("Indique que operacion Matematica desea: 1 para Suma, 2 para division, 3 Adios");
	dat = Console.ReadLine();
	opcion = Convert.ToInt32(dat);

	if (opcion == 1)
	{
		Console.WriteLine("Indique primer numero");
		dat = Console.ReadLine();
		primer = Convert.ToInt32(dat);

		Console.WriteLine("Indique segundo numero");
		dat = Console.ReadLine();
		segundo = Convert.ToInt32(dat);

		resultado = primer + segundo;

		Console.WriteLine("El resultado de la suma es {0}", resultado);

	}
	else if (opcion == 2)
	{
		Console.WriteLine("Indique primer numero");
		dat = Console.ReadLine();
		primer = Convert.ToInt32(dat);

		Console.WriteLine("Indique primer numero");
		dat = Console.ReadLine();
		segundo = Convert.ToInt32(dat);

		resultado = primer / segundo;

		Console.WriteLine("El resultado de la Division es {0}", resultado);

	}

	else if (opcion == 3)
	{
		Console.WriteLine("Adios");
	}
}

void ObtenerGanacia()
{

	string obtener = "";
	double litros = 0.0;
	double galon = 3.785;
	double preciogalones = 0.0;
	double galones = 0.0;
	double ganancia = 0.0;

	Console.WriteLine("cuantos litros saco hoy");
	obtener = Console.ReadLine();
	litros = Convert.ToDouble(obtener);

	galones = litros / galon;

	Console.WriteLine("Cuantos le pagan por galon");
	obtener = Console.ReadLine();
	preciogalones = Convert.ToDouble(obtener);

	ganancia = preciogalones * galones;

	Console.WriteLine("La ganancia es {0}", ganancia);
}

void CalcularSueldoSemanal()
{
	string datos = "";
	double horas = 0.0;
	double dinero = 0.0;
	double semanal = 0.0;


	Console.WriteLine("Cuantas horas a la semana trabaja");
	datos = Console.ReadLine();
	horas = Convert.ToDouble(datos);

	Console.WriteLine("Cuanto dinero recibe por hora");
	datos = Console.ReadLine();
	dinero = Convert.ToDouble(datos);

	semanal = horas * dinero;


	Console.WriteLine("El sueldo es {0}", semanal);
}
