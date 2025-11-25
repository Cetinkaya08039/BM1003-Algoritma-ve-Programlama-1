namespace Alistirma1Cevap
{
    internal class Program
    {
        static void toplam()
        {
            Console.Write("Birinci sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam: " + (x*x + y*y));
        }
        static void Main(string[] args)
        {
            /*
            Kullanıcının girdiği 2 sayının karelerinin toplamını hesaplayıp geri döndüren bir metot yazınız
            */
            toplam();

        }
    }
}

