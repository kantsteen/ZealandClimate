namespace ZealandClimate
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Lokale lokale1 = new Lokale("3.05", 30);
            Lokale lokale2 = new Lokale("3.06", 30);


            Måling måling1 = new Måling(DateTime.Now, 22.5, 445, 30, lokale1);

            Console.WriteLine(lokale1);

            Console.WriteLine(lokale1);
            Console.WriteLine(måling1 + Environment.NewLine);

            register.OpretMåling(DateTime.Now, 22.5, 450, 28, lokale1);
            register.OpretMåling(DateTime.Now, 24, 400, 24, lokale1);
            register.OpretMåling(DateTime.Now, 22, 350, 19, lokale1);


            register.PrintAlleMålinger();



            Console.WriteLine("hent måling 4: " + register.HentMåling(4));



            register.OpretMåling(DateTime.Now, 25, 1100, 30, lokale2);
            register.OpretMåling(DateTime.Now, 26, 1250, 25, lokale2);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Antal ulovlige CO2 målinger: " + register.AntalUlovligeCO2Målinger());


        }
    }
}
