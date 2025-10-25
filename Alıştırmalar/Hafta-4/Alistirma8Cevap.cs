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
            string sayistr = Console.ReadLine();
            int sayiint = Convert.ToInt32(sayistr);
            int basamaksayi = sayistr.Length;
            int[] basamak = new int[basamaksayi];
            int toplam = 0;
            for (int i = 0; i < basamaksayi; i++)
            {
                if (i == 0)
                {
                    // Convert.ToInt32 sayıyı yuvarlıyordu örneğin sayı 5.6 ise 5 çıkartmak yerine 6 yapıyordu bunun yerine (int) kullanıldı.
                    basamak[i] = (int)(sayiint / Math.Pow(10, basamaksayi-1));
                }
                else if (i == basamaksayi-1)
                {
                    basamak[i] = sayiint % 10;
                }
                else
                {
                    basamak[i] = (int)(sayiint % Math.Pow(10, basamaksayi - i) / Math.Pow(10,basamaksayi -1- i));
                }
                toplam += basamak[i];
            }
            Console.WriteLine("Girdiğiniz sayının rakamları toplamı: " + toplam);
        }
    }
}
