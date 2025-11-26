namespace Alistirma15Cevap
{
    internal class Program
    {
        static double[] ac(double k1, double k2)
        {
            double[] ac = new double[2];
            ac[0] = k1*k2;
            ac[1] = 2*k1 + 2*k2;
            return ac;
        }
        static void Main(string[] args)
        {
            /*
            Bir dikdörtgenin 2 kenarını parametre olarak alan ve bu dikdörtgenin alanını ve çevresini hesaplayan programı yazınız.
            */
            Console.Write("Dikdörtgenin uzun kenarını giriniz: ");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin kısa kenarını giriniz: ");
            double k2 = Convert.ToInt32(Console.ReadLine());
            double[] dac = ac(k1, k2);
            Console.WriteLine("Dikdörtgenin alanı: " + dac[0]);
            Console.WriteLine("Dikdörtgenin çevresi: " + dac[1]);
        }
    }
}
