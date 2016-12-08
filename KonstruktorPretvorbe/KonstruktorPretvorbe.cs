﻿using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Racionalni rac = new Racionalni(25);
                //Debug.Assert(rac.ToString() == "25 / 1");
                Console.WriteLine(rac);

                // Naredba koja poziva konstruktor pretvorbe iz double
                rac = new Racionalni(0.25);
                Debug.Assert(rac.ToString() == "1 / 4");
                Console.WriteLine(rac);

                // Naredba koja poziva konstruktor pretvorbe iz double
                rac = new Racionalni(0.125);
                Debug.Assert(rac.ToString() == "1 / 8");
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
