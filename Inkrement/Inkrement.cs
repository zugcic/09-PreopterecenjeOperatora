using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StrukturaDatum:");

            StrukturaDatum sd = new StrukturaDatum(2015, 12, 31);

            StrukturaDatum sdPrefix = ++sd;
            Debug.Assert(sdPrefix.ToString() == "1.1.2016");
            Console.WriteLine(sdPrefix);

            StrukturaDatum sdPostfix = sd++;
            Debug.Assert(sdPostfix.ToString() == "1.1.2016");
            Console.WriteLine(sdPostfix);

            Debug.Assert(sd.ToString() == "2.1.2016");
            Console.WriteLine(sd);

            
            Console.WriteLine("KlasaDatum:");

            KlasaDatum kd = new KlasaDatum(2016, 2, 28);

            KlasaDatum kd2 = ++kd;
            Console.WriteLine(kd2);
            
            KlasaDatum kd3 = kd++;
            Console.WriteLine(kd3);

            Console.WriteLine(kd);
            Console.WriteLine(kd2);

            Console.ReadKey();
        }
    }
}
