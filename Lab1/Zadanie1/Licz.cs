namespace Lab1
{
    class Licz
    {
        //i
        //public float wartosc;

        float wartosc;


        public Licz(float wartosc)
        {
            this.wartosc = wartosc;
        }

        //ii
        public float Dodaj(float a)
        {
            return wartosc += a;
        }
        //iii
        public float Odejmij(float a)
        {
            return wartosc -= a;
        }

        public void Wypisz()
        {
            Console.WriteLine("Wartosc: " + wartosc);
        }
    }
}
