namespace Alistirma30Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ay numarasına(1–12) göre mevsimi yazdırınız(Kış / İlkbahar / Yaz / Sonbahar) – switch-case ile.

            Not:
            Kullanıcı hatalı bir değer girdiğinde(ay numarası 1-12 dışında olduğunda), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */

            while (true)
            {
                Console.Write("Ay numarasını giriniz(1/12): ");
                int ay = Convert.ToInt32(Console.ReadLine());

                switch (ay)
                {
                    case 12:
                    case 1:
                    case 2:
                        {
                            Console.WriteLine("Kış.");
                            break;

                        }
                    case 3:
                    case 4:
                    case 5:
                        {
                            Console.WriteLine("İlkbahar.");
                            break;
                        }
                    case 6:
                    case 7:
                    case 8:
                        {
                            Console.WriteLine("Yaz.");
                            break;
                        }
                    case 9:
                    case 10:
                    case 11:
                        {
                            Console.WriteLine("Sonbahar.");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Hatalı ay numarası girdiniz!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            continue;
                        }

                }
                break;
            }

        }
    }
}
