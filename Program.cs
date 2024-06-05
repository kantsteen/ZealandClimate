namespace ZealandClimate
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Lokale lokale1 = new Lokale("3.05", 30);


            Måling måling1 = new Måling(DateTime.Now, 22.5, 445, 30, lokale1);

            MålingRegister register = new MålingRegister();

            Console.WriteLine(lokale1);
            Console.WriteLine(måling1 + Environment.NewLine);

            Console.WriteLine(register);

        }
    }
}
