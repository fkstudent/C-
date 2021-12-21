class Data
{
    public int dzien { get; private set; }
    public int miesiac { get; private set; }
    public int rok { get; private set; }

    public Data(int dzien, int miesiac, int rok)
    {
        this.dzien = dzien;
        this.miesiac = miesiac;
        this.rok = rok;
    }

    int[] DniWMiesiacu = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public Data dodajTydzien()
    {
        dzien += 7;
        if (dzien>DniWMiesiacu[this.miesiac-1])
        {
            dzien -= DniWMiesiacu[miesiac - 1];
            this.miesiac++;
        }

        if (this.miesiac > 12)
        {
            miesiac = 1;
            rok++;
        }
        return this;
    }

    public Data odejmijTydzien()
    {
        dzien -= 7;
        if (dzien < 1)
        {
            dzien += DniWMiesiacu[miesiac == 1 ? 11: miesiac-2];
            this.miesiac--;
        }

        if (this.miesiac < 1)
        {
            miesiac = 12;
            rok--;
        }
        return this;
    }

    public void Date()
    {
        
    }

    public void WypiszDate()
    {
        Console.WriteLine(dzien+"-"+miesiac+"-"+rok);
    }
}
