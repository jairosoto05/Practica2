using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            Console.WriteLine("ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("el numero "+ numero +" es par");
            }
            else
            {
                Console.WriteLine("el numero " + numero + " es inpar");
            }

            Console.ReadKey();

        }
    }
}
