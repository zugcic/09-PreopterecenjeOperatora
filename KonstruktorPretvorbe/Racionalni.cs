using System;

namespace Vsite.CSharp
{
    public struct Racionalni
    {
        public Racionalni(long brojnik = 0, long nazivnik = 1) : this()
        {
            Brojnik = brojnik;
            Nazivnik = nazivnik;
        }

        public long Brojnik
        {
            get;
            private set;
        }

        public long Nazivnik
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return string.Format("{0} / {1}", Brojnik, Nazivnik);
        }

		// dodati konstruktor pretvorbe (konverzije) koji stvara racionalni broj iz tipa double i u 
		//njemu treba samo pozvati metodu Raščlani. 
		//Otkomentirati naredbe u Main metodi koje pozivaju taj konstruktor.
		public Racionalni(double broj) : this()
		{
			Raščlani(broj);
		}
		
		//U strukturu Racionalni iz prethodnog projekta dodati operator implicitne konverzije iz long u Racionalni
		public static implicit operator Racionalni(double broj)
		{
			return new Racionalni(broj);
		}
		
		//U strukturu Racionalni iz prethodnog projekta dodati operator implicitne konverzije iz double u Racionalni
		public static implicit operator Racionalni(long broj)
		{
			return new Racionalni(broj);
		}


		private void Raščlani(double broj)
        {
            long brojnik = (long)broj;
            long nazivnik = 1;
            while (brojnik - broj * nazivnik != 0 && nazivnik < 1e10)
            {
                nazivnik *= 10;
                brojnik = (long)(broj * nazivnik);
            }
            long nzv = NajvećiZajedničkiVišekratnik(brojnik, nazivnik);
            Brojnik = brojnik / nzv;
            Nazivnik = nazivnik / nzv;
        }

        private long NajvećiZajedničkiVišekratnik(long prviBroj, long drugiBroj)
        {
            if (prviBroj == drugiBroj)
                return prviBroj;
            if (prviBroj > drugiBroj)
                return SljedećiVišekratnik(drugiBroj, prviBroj);
            return SljedećiVišekratnik(prviBroj, drugiBroj);
        }

        private long SljedećiVišekratnik(long manjiBroj, long veciBroj)
        {
            long ostatak = veciBroj % manjiBroj;
            if (ostatak == 0)
                return manjiBroj;
            return SljedećiVišekratnik(ostatak, manjiBroj);
        }
    }
}
