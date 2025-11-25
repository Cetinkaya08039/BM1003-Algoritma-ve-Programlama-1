namespace Alistirma3Cevap
{
    internal class Program
    {
        static int yakin(int x, int y)
        {
            if (x != y)
            {
                if (Math.Abs(100 - x) > Math.Abs(100 - y))
                { 
                    return y; 
                }
                else
                {
                    return x;
                }
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            /*
            Verilen iki tam sayıdan 100 değerine en yakın sayıyı kontrol eden bir metot yazınız.İki sayı eşitse 0 dönsün.
            Örnek Giriş :
            78, 95
            95, 95
            99, 70
            Beklenen Çıkış :
            95
            0
            99  
            */
            Console.Write("Birinci sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yakin(x,y));
        }
    }
}
