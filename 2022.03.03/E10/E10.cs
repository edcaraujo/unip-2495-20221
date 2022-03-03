using System;

namespace Exemplos
{
    class E10
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Seja bem-vindo, {nome}!");

            Console.WriteLine("Vamos somar!");
            Console.Write("X = ");
            string xs = Console.ReadLine();

            Console.Write("Y = ");
            string ys = Console.ReadLine();

            int x = Convert.ToInt32(xs);
            int y = Convert.ToInt32(ys);

            Console.WriteLine($"Soma: {x + y}");
        }
    }
}