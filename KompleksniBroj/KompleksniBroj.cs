using System;

namespace Vsite.CSharp
{
    // primjer preopterećivanja operatora za korisnički definiranu strukturu

    struct KompleksniBroj
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBroj(double realniDio, double imaginarniDio)
        {
            RealniDio = realniDio;
            ImaginarniDio = imaginarniDio;
        }

        public override string ToString()
        {
            if (ImaginarniDio == 0)
                return RealniDio.ToString();
            if (RealniDio == 0)
                return string.Format("{0}i", ImaginarniDio);
            if (ImaginarniDio < 0)
                return string.Format("{0} - {1}i", RealniDio, -ImaginarniDio);
            return string.Format("{0} + {1}i", RealniDio, ImaginarniDio);
        }

        public static KompleksniBroj operator +(KompleksniBroj br1, KompleksniBroj br2)
        {
            // TODO: implementirati binarni operator + (za zbrajanje dva kompleksna broja)
            throw new NotImplementedException();
        }

        // TODO: implementirati binarni operator - (za oduzimanje dva kompleksna broja)


        // TODO: implementirati preopterećeni unarni operator - (za promjenu predznaka)

    }
}
