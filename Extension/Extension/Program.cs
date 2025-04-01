namespace Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 24;
            Console.WriteLine($"Cut ededdir:{num.IsEven()}");
            Console.WriteLine($"Tek ededdir:{num.IsOdd ()}");

            string str = "A2ueu";
            Console.WriteLine($"Daxilinde reqem var:{ str.HasDigit()}");

            string password = "aA12fjsd";
            Console.WriteLine($"Sifre qaydalara uygundur:{password .CheckPassword ()}");

            string text = "axcvfvgrtg";
            Console.WriteLine(text .ToCapitalize ());
        }
    }
}
