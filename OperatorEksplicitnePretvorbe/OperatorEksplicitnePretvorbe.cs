using System;
using System.Diagnostics;

namespace Vsite.CSharp
{

    // TODO: U strukturi Racionalni oz prethodnog projekta definirati javnu (public) metodu pretvorbe ToDouble() koja će racionalni broj pretvoriti u double i to vratiti kao rezultat


    // TODO: U strukturi Racionalni oz prethodnog projekta definirati operator eksplicitne pretvorbe u double (koji poziva gornju metodu ToDouble)


    // TODO: U strukturi Racionalni oz prethodnog projekta definirati javnu (public) metodu pretvorbe ToInt64() koja će racionalni broj pretvoriti u long i to vratiti kao rezultat


    // TODO: U strukturi Racionalni oz prethodnog projekta definirati operator eksplicitne pretvorbe u long (koji poziva gornju metodu ToInt64)

    class Program
    {
        static void Main(string[] args)
        {
            Racionalni rac = new Racionalni(2, 3);
            // eksplicitna pretvorba
            //long racKaoInt = (long)rac;
            //Debug.Assert(racKaoInt == 0);
            //Console.WriteLine(racKaoInt);

            //double racKaoDouble = (double)rac;
            //Debug.Assert(racKaoDouble == (2.0 / 3.0));
            //Console.WriteLine(racKaoDouble);

            Console.WriteLine("GOTOVO!!!!");
            Console.ReadKey();
        }
    }
}
