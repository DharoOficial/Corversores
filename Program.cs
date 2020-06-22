using System;

namespace Estatica
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine( Converter.DolarParaReal(1500f));
            System.Console.WriteLine( Converter.RealParaDolar(30f));
            System.Console.WriteLine( Converter.EuroParaReal(30f));
            System.Console.WriteLine( Converter.RealParaEuro(500));
        }
    }
}
