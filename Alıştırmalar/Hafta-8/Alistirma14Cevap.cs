namespace Alistirma14Cevap
{
    internal class Program
    {
        static double hipo(double k1, double k2)
        {
            return Math.Sqrt(k1*k1+k2*k2);
        }
        static void Main(string[] args)
        {
            /*
            Bir üçgenin iki dik kenarını parametre olarak alan ve hipotenüsünü hesaplayan bir metot yazınız.
            */
            Console.Write("Dik üçgenin birinci dik kenarını giriniz:");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dik üçgenin ikinci dik kenarını giriniz:");
            double k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hiptenüs: " + hipo(k1,k2));
        }
    }
}
