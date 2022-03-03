using System;

namespace Exemplos
{
    class E06
    {
        static void Main(string[] args)
        {
            // Conversão (Casting) implícita
            short x = 23;
            int y = x;
            long z = y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // Conversão (Casting) explícita
            long a = 21474836479000000L;
            int b = (int) a;
            short c = (short) b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}