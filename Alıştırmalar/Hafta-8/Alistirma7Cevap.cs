namespace Alistirma7Cevap
{
    internal class Program
    {
        static int yas(int dyil)
        {
            return DateTime.Today.Year - dyil;
        }
        static void Main(string[] args)
        {
            /*
            Bir kişinin doğum tarihini yıl olarak parametre alan ve kişinin yaşını hesaplayıp ekrana yazdıran bir metot tanımlayınız.

            Not:
            Kullanıcı hatalı bir değer girdiğinde(doğum yılı bulunan yıldan büyük yada 1900'den küçük olduğunda), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */
            while (true)
            {
                Console.Write("Doğum yılınızı giriniz: ");
                int dyil = Convert.ToInt32(Console.ReadLine());
                if (dyil > DateTime.Today.Year || dyil < 1900)
                {
                    Console.WriteLine("Hatalı doğum yılı girildi!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                Console.WriteLine(yas(dyil));
                break;
            }
        }
    }
}
