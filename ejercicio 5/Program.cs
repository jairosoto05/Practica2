using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 18765.43;

            void mostrarBalance()
            {
                Console.WriteLine("su balance disponible es de RD${0:n} pesos \n", balance);
            }

            void bank()
            {
                Console.WriteLine("Presione R para hacer un retiro, C para consultar balance y S para salir");
                ConsoleKeyInfo accion = Console.ReadKey(true);

                if (accion.KeyChar == 'c')
                {
                    mostrarBalance();
                    bank();
                }
                else if (accion.KeyChar == 'r')
                {
                    Console.WriteLine("Ingrese el monto a retirar");
                    double retiro = Convert.ToDouble(Console.ReadLine());
                    if (retiro <= balance)
                    {
                        balance -= retiro;
                        Console.WriteLine("retiro exitoso");
                        mostrarBalance();
                        
                    }
                    else
                    {
                        Console.WriteLine("no tiene balance suficiente para hacer este retiro");
                        mostrarBalance();
                    }
                    bank();
                }
                else if (accion.KeyChar == 's')
                {

                }

            }

            bank();


        }
    }
}
