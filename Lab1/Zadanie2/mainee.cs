namespace Zadanie2
{
    internal class mainee
    {
        static void Main(string[] args)
        {
            int[] Liczby = { 3, 5, 7, 8, 12, 6, 7 };
            int suma = 0;
            Sumator sum = new Sumator(Liczby, suma);
            Console.WriteLine("Suma: ");
            Console.WriteLine(sum.Suma());

            Console.WriteLine("Suma podzielnych przez 2: ");
            Console.WriteLine(sum.SumaPrzez2());

            Console.WriteLine("Ilosc elementow: ");
            Console.WriteLine(sum.IleElementow());

            sum.Wypisywanie();

            Console.WriteLine("Indeksy");
            sum.Index(1, 4);
        }
    }
}
