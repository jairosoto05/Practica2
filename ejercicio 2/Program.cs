using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad <= 10)
            {
                Console.WriteLine("niño");
            }
            else if(edad <= 17)
            {
                Console.WriteLine("adolescente");
            }
            else if (edad <= 38)
            {
                Console.WriteLine("adulto joven");
            }
            else if (edad <= 59)
            {
                Console.WriteLine("mediana edad");
            }
            else
            {
                Console.WriteLine("adulto mayor");
            }

            Console.ReadKey();
        }
    }
}
