namespace Alistirma22Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan alınan sayının kaç basamaklı olduğunu bulan programı yazınız. (örn. 3456 → 4 basamaklıdır.)
            */
          
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayi2 = sayi;
            int basamak = 0;

            while (true)
            {
                if (sayi2 > 0 )
                {
                    sayi2 = sayi2 / 10;
                    basamak++;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(sayi + " sayısı " + basamak + " basamaklıdır.");


        }
    }
}
