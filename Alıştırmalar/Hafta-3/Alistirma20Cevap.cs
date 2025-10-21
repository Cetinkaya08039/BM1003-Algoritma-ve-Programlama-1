namespace Alistirma20Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan iki sayı alın. Eğer ikinci sayı sıfır değilse bölme işlemini yapıp sonucu
            yazdırın, aksi halde “Hata: Sıfıra bölme yapılamaz” mesajı veriniz.
            */

            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            if (sayi2 != 0)
            {
                Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sayi1/sayi2);
            }
            else
            {
                Console.WriteLine("Hata: Sıfıra bölme yapılamaz!");
            }

        }
    }
}
