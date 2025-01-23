using System;

namespace prueba6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Escribe un numero para revisar si es primo o no");
            numero = int.Parse(Console.ReadLine());

            if (EsPrimo(numero))
            {
                Console.WriteLine("El numero ingresado si es primo");
            }
            else
            {
                Console.WriteLine("El numero ingresado no es primo");
            }
            
            static bool EsPrimo(int numero)
            {
                if (numero < 2)
                {
                    return false;
                }
                
                for (int i = 2; i < Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}