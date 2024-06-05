namespace ZealandClimate
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Lokale lokale1 = new Lokale("3.05", 30);
            Lokale lokale2 = new Lokale("3.05", 30);
            Lokale lokale3 = new Lokale("3.05", 30);
            Lokale lokale4 = new Lokale("3.05", 30);


            Måling måling1 = new Måling(DateTime.Now, 22.5, 445, 30, lokale1);

            Console.WriteLine(lokale1);

            Console.WriteLine(måling1 + Environment.NewLine);

            Console.WriteLine(register);

        }
    }
}
