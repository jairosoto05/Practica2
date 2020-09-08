using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("s-sumar   r-restar");
            ConsoleKeyInfo operador = Console.ReadKey(true);

            Console.WriteLine("ingrese un numero");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");
            int b = Convert.ToInt32(Console.ReadLine());

            if (operador.KeyChar == 's')
            {
                Console.WriteLine("el resultado de la suma es "+ (a+b));
            }
            else if (operador.KeyChar == 'r')
            {
                Console.WriteLine("el resultado de la resta es "+ (a-b));
            }
            Console.ReadKey();
        }
    }
}
