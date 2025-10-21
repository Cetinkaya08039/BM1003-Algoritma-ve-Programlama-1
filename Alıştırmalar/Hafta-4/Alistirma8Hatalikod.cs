namespace Alistirma8Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir tam sayının rakamlarının toplamını hesaplayan programı yazınız.
            Giriş Verileri:
            Bir tamsayı girin: 253
            Beklenen çıktı:
            Rakamların toplamı: 10
            */
            Console.Write("Bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int basamak = 0;

            if (sayi == 0)
            {
                basamak++;
            }
            if (sayi < 0 )
            {
                sayi = -sayi;
            }
            int sayi2 = sayi;
            while (sayi2 > 0)
            {
                sayi2 = sayi2 / 10;
                basamak++;
            }

            double toplam = 0;
            for (int i = 1; i <= basamak; i++)
            {
                if (i == basamak - 1)
                {
                    toplam += sayi / Math.Pow(10, i);
                }
                else if (i != 1)
                {
                    toplam += (sayi % Math.Pow(10, i)) / Math.Pow(10, i);

                }
                else
                {
                    toplam += (sayi % Math.Pow(10, i));

                }
            }
            Console.WriteLine(Convert.ToInt32(toplam));
        }
    }
}
