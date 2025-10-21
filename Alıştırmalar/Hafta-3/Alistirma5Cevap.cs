namespace Alistirma5Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            İki tam sayıyı kabul eden ve eşit olup olmadıklarını kontrol eden programı yazın.
            */
          
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 == sayi2)
            {
                Console.WriteLine("Girdiğiniz sayılar birbirine eşittir.");
            }
            else if (sayi1 < sayi2)
            {
                Console.WriteLine("İkinci girdiğiniz sayı birinci sayıdan büyüktür.");
            }
            else
            {
                Console.WriteLine("Birinci girdiğiniz sayı ikinci sayıdan büyüktür.");
            }
        }
    }
}
