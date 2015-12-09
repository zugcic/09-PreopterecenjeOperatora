using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    static class Datum
    {
        public static bool JeLiPrestupnaGodina(int godina)
        {
            if (godina % 400 == 0)
                return true;
            if (godina % 100 == 0)
                return false;
            return godina % 4 == 0;
        }

        public static int BrojDanaUMjesecu(int mjesec, int godina)
        {
            switch (mjesec)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return JeLiPrestupnaGodina(godina) ? 29 : 28;
                default:
                    throw new ArgumentOutOfRangeException("mjesec");
            }
        }
    }
}
