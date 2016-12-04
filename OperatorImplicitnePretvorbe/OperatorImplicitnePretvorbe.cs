using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    // TODO: U strukturu Racionalni iz prethodnog projekta dodati operator implicitne konverzije iz long u Racionalni, otkomentirati donje naredbe i pokrenuti program



    // TODO: U strukturu Racionalni iz prethodnog projekta dodati operator implicitne konverzije iz double u Racionalni, otkomentirati donje naredbe i pokrenuti program


    class OperatorImplicitnePretvorbe
    {
        static void Main(string[] args)
        {
            try
            {
                Racionalni rac = new Racionalni();
                // koristi implicitnu pretvorbu iz double
                //rac = 0.1;
                //Debug.Assert(rac.ToString() == "1 / 10");
                Console.WriteLine(rac);

                // koristi implicitnu pretvorbu iz double
                //rac = 2;
                //Debug.Assert(rac.ToString() == "2 / 1");
                Console.WriteLine(rac);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
