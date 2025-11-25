namespace Alistirma9Cevap
{
    internal class Program
    {
        static int bsmkhesap(int x)
        {
            int basamak = 0;
            while (x>0)
            {
                x /= 10;
                basamak++;
            }
            return basamak;
        }
        static void Main(string[] args)
        {
            /*
            Pozitif bir sayıyı parametre olarak alan ve bu sayının kaç basamaklı olduğunu hesaplayıp geri döndüren bir metot tanımlayınız.
            */
            while (true)
            {
                Console.Write("Pozitif bir tam sayı girin: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x>0)
                {
                    Console.WriteLine("Basamak sayısı: " + bsmkhesap(x));
                    break;
                }
                Console.WriteLine("Pozitif tam sayı girmeniz gerekmekte!");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
