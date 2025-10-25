namespace Alistirma10Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden girilen maksimum 20 karakterli bir kelimedeki sesli harflerin sayısının toplam
            karakter sayısına göre oranını hesaplayınız.

            Not:
            Kullanıcı hatalı bir değer girdiğinde(20 karakterden uzun bir kelime girdiğinde), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */

            while (true)
            {
                Console.Write("Maksimum 20 karakterli bir kelime giriniz: ");
                string kelime = Console.ReadLine();
                int uzunluk = kelime.Length;
                double toplamsesli = 0;
                string[] harfler = new string[kelime.Length];
                if (kelime.Length > 20)
                {
                    Console.WriteLine("Girdiğiniz kelime maksimum 20 karakterli olmalı!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    for (int i = 0; i < harfler.Length; i++)
                    {
                        harfler[i] = kelime.Substring(i, 1);
                        if ("aeoöuüıi".Contains(harfler[i]) || "AEOÖUÜIİ".Contains(harfler[i]))
                        {
                            toplamsesli++;
                        }
                    }
                    Console.WriteLine("Girdiğiniz kelimedeki toplam sesli harf sayısı: " + toplamsesli + ", toplam harf sayısı: " + kelime.Length);
                    Console.WriteLine("Bu ikisinin oranı: " + toplamsesli/kelime.Length);
                    break;
                }
            }
        }
    }
}
