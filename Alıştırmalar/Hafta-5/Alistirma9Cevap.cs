namespace Alistirma9Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Girilen bir cümlede, girilen bir karakterden kaç tane olduğunu bulan programı yazınız.

            Not:
            Kullanıcı hatalı bir değer girdiğinde(birden fazla karakter girdiğinde), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */
            while (true)
            {
                Console.Write("Bir cümle giriniz: ");
                string cumle = Console.ReadLine();
                Console.Write("Bir karakter giriniz: ");
                string karakter = Console.ReadLine();
                string[] harfler = new string[cumle.Length];
                int miktar = 0;
                if (karakter.Length > 1)
                {
                    Console.WriteLine("Sadece bir karakter girmeniz gerekmekte!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    for (int i = 0; i < cumle.Length; i++)
                    {
                        harfler[i] = cumle.Substring(i, 1);
                        if (harfler[i] == karakter.ToLower() || harfler[i] == karakter.ToUpper())
                        {
                            miktar++;
                        }
                    }
                    Console.WriteLine("Girdiğiniz cümlede " + karakter + " harfi " + miktar + " defa geçmekte.");
                    break;
                }

            }
        }
    }
}
