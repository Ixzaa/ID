using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int opcion = 0;
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.WriteLine("Bienvenido al menú de operaciones:");
            Console.WriteLine("1. Pares e Impares");
            Console.WriteLine("2. Tabla de multiplicar");
            Console.WriteLine("3. Factorial de un número");
            Console.WriteLine("4. Números Primos");
            Console.WriteLine("5. Sucesión de Fibonacci");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese una opción del 1 al 6: ");

        }
         while (opcion != 6); // Continuar hasta que se seleccione la opción 6 (Salir)
        
    }
}