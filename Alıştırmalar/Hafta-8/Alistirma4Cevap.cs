namespace Alistirma4Cevap
{
    internal class Program
    {
        static void islem()
        {
            Console.Write("Birinci sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x +y)*z);
        }
        static void Main(string[] args)
        {
            /*
            Parametre olarak üç sayı(x, y, z) alan ve(x+y).z çıktısını geri döndüren bir metodu yazınız.
            */
            islem();
        }
    }
}
