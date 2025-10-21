namespace Alistirma12Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan 3 sayı alıp en büyüğünü bulan programı yazınız(if-else kullanarak)
            */

            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz: ");
            double sayi3 = Convert.ToDouble(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("En büyük sayı: " + sayi1);
            }
            else if (sayi2 > sayi3 && sayi2 > sayi1)
            {
                Console.WriteLine("En büyük sayı: " + sayi2);
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                Console.WriteLine("En büyük sayı: " + sayi3);
            }
            else
            {
                Console.WriteLine("Hata!");
            }

        }
    }
}
