namespace Alistirma5Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Verilen sayıya kadar bir tamsayının küpünü görüntüleyen bir C# Sharp programı yazın.
            Örnek:
            Girilen terim sayısı: 5
            Beklenen Çıktı :
            Sayı: 1 ve 1'in küpü :1
            Sayı: 2 ve 2'nin küpü :8
            Sayı: 3 ve 3'ün küpü :27
            Sayı: 4 ve 4'ün küpü :64
            Sayı: 5 ve 5'in küpü :125
            */
          
            Console.Write("Terim sayısını giriniz: ");
            int ts = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ts; i++)
            {
                Console.WriteLine("Sayı: " + i + " ve " + i + "'nin küpü: " + i*i*i);
            }
        }
    }
}
