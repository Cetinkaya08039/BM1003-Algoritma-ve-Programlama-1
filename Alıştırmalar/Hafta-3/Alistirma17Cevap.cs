namespace Alistirma17Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan kullanıcı adı ve şifre alınsın.
            Eğer kullanıcı adı = "admin" ve şifre = "1234" ise “Giriş başarılı”
            Aksi halde “Hatalı giriş” yazan programı yapınız.
            */
          
            Console.Write("Kullanıcı adınızı giriniz: ");
            string kadi = Console.ReadLine();
            Console.Write("Şifrenizi giriniz: ");
            string sifre = Console.ReadLine();
            if (kadi == "admin" && sifre == "1234")
            {
                Console.WriteLine("Giriş başarılı!");
            }
            else
            {
                Console.WriteLine("Hatalı giriş!");
            }
        }
    }
}
