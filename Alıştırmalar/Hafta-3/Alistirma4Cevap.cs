namespace Alistirma4Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Giriş olarak bir karakteri alan ve bunun sesli harf, rakam veya başka bir sembol olup olmadığını kontrol eden programı yazın.

            Not:
            Kullanıcı hatalı bir değer girdiğinde, program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */

            while (true)
            {
                Console.Write("Bir karakter giriniz: ");
                string karakter = Console.ReadLine();
                if ("aeoöuüıi".Contains(karakter))
                {
                    Console.WriteLine("Girdiğiniz karakter bir sesli harftir!");
                    break;
                }
                else if ("0123456789".Contains(karakter))
                {
                    Console.WriteLine("Girdiğiniz karakter bir sayıdır!");
                    break;
                }
                else if ("qwrtypğsdfghjklşzxcvbnmç".Contains(karakter))
                {
                    Console.WriteLine("Girdiğiniz karakter bir sessiz harftir!");
                    break;
                }
                else if ("!\"^+%&/()=?_*-'#:;.,<>@${}[]\\|€~£".Contains(karakter))
                {
                    Console.WriteLine("Girdiğiniz karakter bir semboldür!");
                    break;
                }
                else
                {
                    Console.WriteLine("Sadece bir karakter girmeniz gerekmekte!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
}
