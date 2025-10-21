namespace Alistirma32Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ATM menüsü(switch-case):
            1 - Para Yatır,
            2 - Para Çek,
            3 - Bakiye,
            4 - Çıkış.Seçime göre uygun mesaj / işlem akışını yazdırınız(sadece menü ve mesaj;gerçek bakiye takibi gerekmez).
            */

            while (true)
            {
                Console.Write("Gitmek istediğiniz menünün numarasını giriniz(1 - Para Yatır, 2 - Para çek, 3 - Bakiye, 4 - Çıkış): ");
                int menuno = Convert.ToInt32(Console.ReadLine());
                switch (menuno)
                {
                    case 1:
                        {
                            Console.Write("Yatırmak istediğiniz miktarı giriniz: ");
                            string miktar = Console.ReadLine();
                            Console.WriteLine("Başarıyla " + miktar + " TL hesabınıza yatırıldı.");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Çekmek istediğiniz miktarı giriniz: ");
                            string miktar = Console.ReadLine();
                            Console.WriteLine("Başarıyla " + miktar + " TL hesabınızdan çekildi.");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Random rnd = new Random();
                            Console.WriteLine(rnd.Next(0,100) + " TL bakiyeniz bulunmakta.");
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Çıkış yapılıyor.");
                            Thread.Sleep(500);
                            Console.Clear();
                            Console.WriteLine("Çıkış yapılıyor..");
                            Thread.Sleep(500);
                            Console.Clear();
                            Console.WriteLine("Çıkış yapılıyor...");
                            Thread.Sleep(1000);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Hatalı menü numarası girildi!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }

                }
                break;
            }
        }
        }
}
