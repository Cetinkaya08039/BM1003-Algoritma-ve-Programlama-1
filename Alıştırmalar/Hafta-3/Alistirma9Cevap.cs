namespace Alistirma9Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir kullanıcının yaşını, cinsiyetini("E" veya "K" olarak) ve sürücü belgesinin olup
            olmadığını('E' veya 'H' olarak) alın.Kullanıcının aşağıdaki kriterlere göre hangi araç
            türünde sürücü olabileceğini belirleyin:
            • 18 yaşından küçükse, "Bisiklet sürücüsü olabilirsiniz." mesajını yazdırın.
            • 18 - 22 yaşları arasında, sürücü belgesi yoksa, "Sürücü belgesi almanız gerekiyor."
            mesajını yazdırın.
            • 18 - 22 yaşları arasında, sürücü belgesi varsa ve cinsiyet "E" ise, "Motosiklet
            sürücüsü olabilirsiniz." mesajını yazdırın.
            • 23 yaş ve üzeri, sürücü belgesi varsa, "Otomobil sürücüsü olabilirsiniz." mesajını
            yazdırın.
            • Diğer tüm durumlar için, "Sürücü kategorisi belirlenemedi." mesajını yazdırın.
            */

            Console.Write("Cinsiyetinizi giriniz(E/K): ");
            string cinsiyet = Console.ReadLine();
            Console.Write("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ehliyetinizin olup olmadığını giriniz(E/H): ");
            string ehliyet = Console.ReadLine();
            if (yas < 18)
            {
                Console.WriteLine("Bisiklet sürücüsü olabilirsiniz.");
            }
            else if ((18 <= yas && yas <= 22) && ehliyet == "H")
            {
                Console.WriteLine("Sürücü belgesi almanız gerekiyor.");
            }
            else if ((18 <= yas && yas <= 22) && ehliyet == "E" && cinsiyet == "E")
            {
                Console.WriteLine("Motosiklet sürücüsü olabilirsiniz.");
            }
            else if (23 <= yas && ehliyet == "E")
            {
                Console.WriteLine("Otomobil sürücüsü olabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Sürücü kategorisi belirlenemedi.");
            }
        }
    }
}
