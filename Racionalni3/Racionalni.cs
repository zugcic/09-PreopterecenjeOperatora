namespace Vsite.CSharp
{
    // primjer pretvorbe u druge tipove i eksplicitne pretvorbe
    struct Racionalni
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

        // TODO: Definirati javnu (public) metodu pretvorbe ToDouble() koja će racionalni broj pretvoriti u double i to vratiti kao rezultat


        // TODO: Definirati operator eksplicitne pretvorbe u double (koji poziva gornju metodu ToDouble)



        // TODO: Definirati javnu (public) metodu pretvorbe ToInt64() koja će racionalni broj pretvoriti u long i to vratiti kao rezultat


        // TODO: Definirati operator eksplicitne pretvorbe u long (koji poziva gornju metodu ToInt64)



    }
}
