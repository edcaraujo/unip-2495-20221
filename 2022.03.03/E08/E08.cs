using System;

namespace Exemplos
{
    enum Turno
    {
        Manha,
        Tarde,
        Noite
    }

    enum Status : short
    {
        Fail    = -1,
        Unknow  = 0,
        Success = 1
        
    }

    class E08
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Turno.Manha);
            Console.WriteLine(Turno.Tarde);
            Console.WriteLine(Turno.Noite);

            Console.WriteLine((int) Turno.Manha);
            Console.WriteLine((int) Turno.Tarde);
            Console.WriteLine((int) Turno.Noite);
        }
    }
}