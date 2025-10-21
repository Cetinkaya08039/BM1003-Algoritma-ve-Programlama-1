namespace Alistirma8Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan alınan iki sayı arasındaki farkın mutlak değerini hesaplayan ve ekrana
            yazdıran bir program yazınız.Eğer fark 10'dan büyükse "Fark 10'dan büyüktür." şeklinde,
            değilse "Fark 10'dan küçük veya eşittir." şeklinde ek bir mesaj da veriniz.
            */
          
            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            double fark = sayi1 - sayi2;
            if (fark < 0 && -fark > 10)
            {
                Console.WriteLine("Girdiğiniz iki sayının farkı " + -fark + "'dir ve aralarındaki fark 10'dan büyüktür!");
            }
            else if (fark < 0 && -fark <= 10)
            {
                Console.WriteLine("Girdiğiniz iki sayının farkı " + -fark + "'dir ve aralarındaki fark 10'dan küçük yada eşittir!");
            }
            else if (fark > 0 && fark > 10)
            {
                Console.WriteLine("Girdiğiniz iki sayının farkı " + fark + "'dir ve aralarındaki fark 10'dan büyüktür!");
            }
            else if (fark > 0 && fark <= 10)
            {
                Console.WriteLine("Girdiğiniz iki sayının farkı " + fark + "'dir ve aralarındaki fark 10'dan küçük yada eşittir!");
            }
            else
            {
                Console.WriteLine("Hata!");
            }
        }
    }
}
