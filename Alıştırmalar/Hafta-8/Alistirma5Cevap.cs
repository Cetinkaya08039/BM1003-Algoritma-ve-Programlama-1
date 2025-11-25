namespace Alistirma5Cevap
{
    internal class Program
    {
        static double donusum(double c)
        {
            return (c * 9 / 5) + 32;
        }
        static void Main(string[] args)
        {
            /*
            Santigrat dereceyi Fahrenheit'e çeviren bir metot yazınız.        
            */
            Console.Write("Santigrat dereceyi giriniz: ");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("°F: " + donusum(C));

        }
    }
}
