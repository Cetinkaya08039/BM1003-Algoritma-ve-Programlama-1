namespace Alistirma4Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1 ile 1000 arasındaki sayılardan 12 ye tam bölünenlerin ortalamasını hesaplayıp ekrana yazdıran programı yazınız.
            */
            double toplam = 0;
            double sayi = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i%12 ==0)
                {
                    toplam += i;
                    sayi++;
                }
            }
            Console.WriteLine("12'ye tam bölünenlerin sayısı = " + sayi + ", bu sayıların toplamı = " + toplam);
            Console.WriteLine("Bu sayıların ortalaması = " + toplam/sayi);
        }
    }
}
