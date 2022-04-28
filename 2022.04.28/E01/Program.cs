using System;

namespace E01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem p = new Personagem();
            Barbaro b = new Barbaro();

            Console.WriteLine(p.Forca);
            Console.WriteLine($"Ataque do personagem {p.atacar()}");
            Console.WriteLine(b.Forca);
            Console.WriteLine($"Ataque do barbaro {b.atacar()}");
        }
    }
}