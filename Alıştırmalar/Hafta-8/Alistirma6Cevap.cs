namespace Alistirma6Cevap
{
    internal class Program
    {
        static int farkmutlak(int x, int y)
        {
            return Math.Abs(x - y);
        }
        static void Main(string[] args)
        {
            /*
            Parametre olarak 2 tam sayıyı alan ve farklarının mutlak değerini geri döndüren bir metot tanımlayınız.
            */
            Console.Write("Birinci sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("|x-y| = " + farkmutlak(x,y));
        }
    }
}
