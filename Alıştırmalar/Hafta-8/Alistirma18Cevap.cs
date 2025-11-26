namespace Alistirma18Cevap
{
    internal class Program
    {
        static void say(int[] dizi)
        {

            int ns = 0;
            int ps = 0;
            int ss = 0;
            Console.Write("Dizideki negatif sayılar: ");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > 0)
                {
                    ps++;
                }
                else if (dizi[i] < 0)
                {
                    Console.Write(dizi[i] + " ");
                }
                else
                {
                    ss++;
                }
            }
            Console.WriteLine("\n" + "Pozitif sayıların sayısı: " + ps);
            Console.WriteLine("Sıfırların sayısı: " + ss);
        }
        static void Main(string[] args)
        {
            /*
            Parametre olarak bir dizi alan ve bu dizideki negatif sayılar ile pozitif sayıların sayısını ekrana yazdıran bir metot yazınız.
            */
            Random rnd = new Random();
            int[] dizi = new int[rnd.Next(1, 11)];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(-9, 10);
            }
            say(dizi);
        }
    }
}
