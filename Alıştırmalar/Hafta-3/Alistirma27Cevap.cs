namespace Alistirma27Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir üçgenin geçerli olup olmadığını kontrol ediniz(üçgen eşitsizliği).
            Geçerli değilse “Geçersiz üçgen” yazdırınız(alan / tür hesaplaması yok).

            Üçgen eşitsizliği, herhangi bir üçgen için her kenarın uzunluğunun, 
            diğer iki kenarın uzunluklarının toplamından küçük veya eşit olması gerektiğini belirten matematiksel bir teoremdir.
            */

            Console.Write("Üçgenin birinci kenar uzunluğunu giriniz: ");
            double kenar1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçgenin ikinci kenar uzunluğunu giriniz: ");
            double kenar2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçgenin üçüncü kenar uzunluğunu giriniz: ");
            double kenar3 = Convert.ToDouble(Console.ReadLine());

            if (kenar1 > kenar2+kenar3)
            {
                Console.WriteLine("Geçersiz üçgen!");
            }
            else if (kenar2 > kenar1 + kenar3)
            {
                Console.WriteLine("Geçersiz üçgen!");
            }
            else if (kenar3 > kenar1 + kenar2)
            {
                Console.WriteLine("Geçersiz üçgen!");
            }
            else
            {
                Console.WriteLine("Geçerli üçgen!");
            }
        }
    }
}
