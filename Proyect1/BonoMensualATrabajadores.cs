namespace Proyect1
{
	public class BonoMensualATrabajadores
	{
		public void BonoMensual()
		{
			int añosAntiguedadTrabajando = 0;
			double salario = 0.0;
			double bonoPorAños = 0.0;
			double bonoPorSalario = 0.0;
			double MontoTotal = 0.0;			
	
			Console.WriteLine("Indique los años de antiguedad trabajando");
			añosAntiguedadTrabajando = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Indique el sueldo");
			salario = Convert.ToDouble(Console.ReadLine());

			bonoPorAños = CalcularBonoPorAntiguedad(añosAntiguedadTrabajando, salario);		
			bonoPorSalario = CalcularBonoPorSalario(salario);		

			MontoTotal = bonoPorAños > bonoPorSalario ? bonoPorAños : bonoPorSalario;

			Console.WriteLine($"Su bono será de {MontoTotal}");
		}

		private double CalcularBonoPorAntiguedad(double añosantiguedadTrabajando, double sueldo)
		{
			double bonoPorAños = 0.0;

			if (añosantiguedadTrabajando > 2 && añosantiguedadTrabajando < 5)
				bonoPorAños =  1.20;
			else if(añosantiguedadTrabajando > 5)
				bonoPorAños =  1.30;

			return bonoPorAños * sueldo;	
		}

		private double CalcularBonoPorSalario(double salario)
		{			
			double bono = 0.0;
			double MontoTotal;

			if (salario < 1000)
			{
				bono = 1.25;
			}
			else if (salario > 1000 && salario <= 3500)
			{
				bono = 1.15;
			}
			else if (salario > 3500)
			{
				bono = 1.10;
			}

			MontoTotal = salario * bono;
			
			return MontoTotal;
		}
	}
}
