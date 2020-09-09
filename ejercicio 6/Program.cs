using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double prestamo;
            int numcuotas;
            double interes;
            double cuotas;

            void calcularCuotas()
            {
                Console.WriteLine("ingrese el monto del prestamo");
                prestamo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad de cuotas");
                numcuotas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese tasa de interes");
                interes = Convert.ToDouble(Console.ReadLine())/1200;

                double factor = Math.Pow(interes + 1, numcuotas);
                cuotas = prestamo * (factor * interes)/(factor - 1);
                Console.WriteLine(Math.Round(cuotas,2));
            }

            calcularCuotas();
            Console.ReadKey();
        }
    }
}
