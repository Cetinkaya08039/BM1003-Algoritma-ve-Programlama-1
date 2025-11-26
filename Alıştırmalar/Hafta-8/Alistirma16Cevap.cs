namespace Alistirma16Cevap
{
    internal class Program
    {
        static double metot(double x, double y)
        {
            return x + y * y;
        }
        static void Main(string[] args)
        {
            /*
            s = x + y2 denklemin sonucunu hesaplayan bir metot yazınız.
            */
            Console.Write("X giriniz: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y giriniz: ");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("s = " + metot(x,y));
        }
    }
}
