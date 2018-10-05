using System;

namespace suma_de_multiplos_de_3_y_5_daparicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingresa un numero: ");

            if (Int32.TryParse(Console.ReadLine(), out num)) {
                int suma = 0;

                for (int i=1; i<=num; i++) {
                    if (i%3 == 0 || i%5 == 0) {
                        Console.WriteLine(i);
                        suma += i;
                    }
                }

                Console.WriteLine("La suma es: " + suma);
            } else {
                Console.WriteLine("El valor introducido no es numérico");
            }
        }
    }
}
