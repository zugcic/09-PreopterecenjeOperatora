using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 2);
            KompleksniBroj kb2 = new KompleksniBroj(0, -4);

            KompleksniBroj zbroj = kb1 + kb2;
            Debug.Assert(zbroj.ToString() == "1 - 2i");
            Console.WriteLine("({0}) + ({1}) = {2}", kb1, kb2, zbroj);

            KompleksniBroj razlika = kb2 - kb1;
            Debug.Assert(razlika.ToString() == "-1 - 6i");
            Console.WriteLine("({0}) + ({1}) = {2}", kb1, kb2, razlika);

            Debug.Assert((-zbroj).ToString() == "-1 + 2i");
            Console.WriteLine("-[({0}) + ({1})] = {2}", kb1, kb2, -(zbroj));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}