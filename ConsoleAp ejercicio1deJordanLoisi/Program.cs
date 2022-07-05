using System;

namespace ConsoleAp_ejercicio1deJordanLoisi
{
    class Program
    {
        static void Main(string[] args)
        {
			double dolar;
			double euro;
			int pesos;

			Console.Write("ingrese el valor de pesos");
			pesos = int.Parse(Console.ReadLine());



			dolar = pesos / 230;
			euro = dolar / 1.17;

			Console.WriteLine($"la cantidad de dolar que puedo comprar es  {dolar}");
			Console.WriteLine($"la cantidad de euros que puedo comprar es  {euro}");
		}
    }
}
