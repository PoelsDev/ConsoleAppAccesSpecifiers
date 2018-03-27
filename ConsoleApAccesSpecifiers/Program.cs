using System;

namespace ConsoleApAccesSpecifiers
{
    class Tafel
    {
        int aantalPoten = 2;

        public void PrintInfo()
        {
            Console.WriteLine("De tafel heeft {0} poten", aantalPoten);
        }
    }
}

namespace MeubelWinkel
{
    using ConsoleApAccesSpecifiers;

    class Program
    {

        static void Main()
        {
            ConsoleApAccesSpecifiers.Tafel t1 = new ConsoleApAccesSpecifiers.Tafel();
            Tafel t2 = new Tafel();
            t1.PrintInfo();
            t2.PrintInfo();
        }
    }
}
