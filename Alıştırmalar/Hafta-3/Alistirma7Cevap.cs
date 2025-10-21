namespace Alistirma7Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir üçgenin Eşkenar, İkizkenar veya Çeşitkenar olup olmadığını kontrol eden programıyazın.
            */

            Console.Write("Üçgenin birinci kenar uzunluğunu giriniz: ");
            double kenar1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçgenin ikinci kenar uzunluğunu giriniz: ");
            double kenar2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçgenin üçüncü kenar uzunluğunu giriniz: ");
            double kenar3 = Convert.ToDouble(Console.ReadLine());

            if (kenar1 == kenar2 && kenar1 != kenar3)
            {
                Console.WriteLine("Üçgeniniz bir ikizkenar üçgendir");
            }
            else if (kenar2 == kenar3 && kenar2 != kenar1)
            {
                Console.WriteLine("Üçgeniniz bir ikizkenar üçgendir");
            }
            else if (kenar1 == kenar3 && kenar1 != kenar2)
            {
                Console.WriteLine("Üçgeniniz bir ikizkenar üçgendir");
            }
            else if (kenar2 == kenar3 && kenar2 == kenar1)
            {
                Console.WriteLine("Üçgeniniz bir eşkenar üçgendir");
            }
            else if (kenar2 != kenar3 && kenar2 != kenar1)
            {
                Console.WriteLine("Üçgeniniz bir çeşitkenar üçgendir");
            }
            else
            {
                Console.WriteLine("Hata!");
            }

        }
    }
}
