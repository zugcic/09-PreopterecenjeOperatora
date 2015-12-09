using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Racionalni rac = new Racionalni(2, 3);
            // eksplicitna pretvorba
            long racKaoInt = (long)rac;
            Debug.Assert(racKaoInt == 0);
            Console.WriteLine(racKaoInt);

            double racKaoDouble = (double)rac;
            Debug.Assert(racKaoDouble == (2.0 / 3.0));
            Console.WriteLine(racKaoDouble);

            Console.ReadKey();
        }
    }
}
