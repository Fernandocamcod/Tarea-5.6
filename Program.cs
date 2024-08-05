using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número entero no negativo: ");
        string input = Console.ReadLine();

        // Verifica que la entrada del usuario es un número entero válido y no negativo
        if (int.TryParse(input, out int numero) && numero >= 0)
        {
            long factorial = 1;
            int i = numero;

            while (i > 1)
            {
                factorial *= i;
                i--;
            }

            Console.WriteLine($"El factorial de {numero} es {factorial}.");
        }
        else
        {
            Console.WriteLine("Por favor, introduce un número entero no negativo válido.");
        }

        // Mantiene la consola abierta hasta que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
