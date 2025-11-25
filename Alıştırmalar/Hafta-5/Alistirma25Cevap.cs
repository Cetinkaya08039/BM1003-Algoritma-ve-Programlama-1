namespace Alistirma25Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            İlk 500 asal sayının toplamını hesaplayan programı yazınız.
            */
            bool asalmi;
            int miktar = 0;
            int toplam = 0;
            for (int i = 2; miktar < 500; i++)
            {
                asalmi = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i%j == 0)
                    {
                        asalmi = false;
                        break;
                    }
                }
                if (asalmi)
                {
                    toplam += i;
                    miktar++;
                }
            }
            Console.WriteLine(toplam);
        }
    }
}
