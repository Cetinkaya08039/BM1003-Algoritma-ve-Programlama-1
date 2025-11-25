namespace Alistirma2Cevap
{
    internal class Program
    {
        static int buyuk(int x, int y, int z)
        {
            int max = Math.Max(x,y);
            int enmax = Math.Max(max,z);
            return enmax;
            
        }
        static void Main(string[] args)
        {
            /*
            Verilen üç tamsayı arasından en büyük sayıyı kontrol eden bir metot yazın.
            */
            Console.Write("Birinci sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(buyuk(x,y,z));
        }
    }
}
