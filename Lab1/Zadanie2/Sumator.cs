class Sumator
{

    private int[] Liczby;
    private float suma = 0;

    public Sumator()
    {
    }

    public Sumator(int[] liczby, float suma)
    {
        Liczby = liczby;
        this.suma = suma;
    }

    public int Suma()
    {
        var suma = 0;
        for (int i = 0; i < Liczby.Length; i++)
        {
            suma += Liczby[i];
        }
        return suma;
    }

    public int SumaPrzez2()
    {
        int sumaprzez2 = 0;
        for (int i = 0; i < Liczby.Length; i++)
        {
            if (Liczby[i] % 2 == 0)
            {
                sumaprzez2 += Liczby[i];
            }

        }
        return sumaprzez2;
    }
    public int IleElementow()
    {

        return Liczby.Length;
    }

    public void Wypisywanie()
    {
        Console.WriteLine("Tablica: ");
        for (int i = 0; i < Liczby.Length; i++)
        {
            Console.WriteLine(Liczby[i]);
        }
    }

    public void Index(int lowIndex, int highIndex)
    {
        for (int i = Math.Max(0,lowIndex); i <= Math.Min(highIndex,Liczby.Length); i++)
        {
            Console.WriteLine(Liczby[i]);
        }
    }
}
