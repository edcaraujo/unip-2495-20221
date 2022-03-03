using System;

namespace Exemplos
{
    class E06
    {
        static void Main(string[] args)
        {
            int x = 25, y = 1, z = 30;

            Console.WriteLine("Valores: " + x + " " + y + " " + z);
            Console.WriteLine($"Valores: {x} {y} {z}");

            const int w = 100; // Valor não pode ser alterado.

            var teste = 78.9; // Tipo implícito.
            
            Console.WriteLine(w);
            Console.WriteLine(teste);
        }
    }
}