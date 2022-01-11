

internal class Program
{
    static void Main(string[] args)
    {


        /*Zadanie1*/
        StreamWriter sw = new StreamWriter("sample.txt");
        sw.WriteLine("117808");
        sw.Close();

        /*Zadanie2*/
        StreamReader sr = new StreamReader("sample.txt");
        var line = sr.ReadToEnd();
        Console.WriteLine(line);
        sr.Close();

        /*Zadanie3*/
        using (var srpes = new StreamReader("pesels.txt"))
        {
            int licznikMezczyzn = 0;
            int licznikkobiet = 0;
            string pesel = srpes.ReadLine();
            while (pesel != null)
            {
                int number = pesel[9] - 48;

                if (number % 2 == 0)
                {
                    licznikkobiet++;
                }
                else
                    licznikMezczyzn++;

                pesel = srpes.ReadLine();

            }
            Console.WriteLine("Kobiety :" + licznikkobiet + " Mezczyzni : " + licznikMezczyzn);
        }
    }
}
