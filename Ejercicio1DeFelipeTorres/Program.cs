using System;

namespace Ejercicio1DeFelipeTorres
{
    class Program
    {
        static void Main(string[] args)
        {
			double Kilometros;
			int Distancia;
			Console.WriteLine("¿A que Velosidad se Desplaza?");
			int Velocidad = int.Parse(Console.ReadLine()) ;

			Console.WriteLine("¿Cuanto Tiempo?");
			int Tiempo = int.Parse(Console.ReadLine());

			Distancia = Velocidad + Tiempo;
			Kilometros = Distancia * 0.001;

			Console.WriteLine($"Recorrio {Distancia} M/S .Es igual a {Kilometros} Km/S");

			Console.ReadLine();
		}
	}
}
