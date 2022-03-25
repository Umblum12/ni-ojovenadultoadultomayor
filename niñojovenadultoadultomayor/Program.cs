using System;

namespace niñojovenadultoadultomayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad <= 12 && edad >=1)
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad >= 13 && edad <= 15)
            {
                Console.WriteLine("Eres un adolescente");
            }
            else if (edad >= 16 && edad <= 17)
            {
                Console.WriteLine("Eres un joven");
            }
            else if (edad >= 18 && edad <= 59)
            {
                Console.WriteLine("Eres un adulto");
            }
            else if (edad >= 60)
            {
                Console.WriteLine("Eres un adulto tercera edad");
            }
        }
    }
}
