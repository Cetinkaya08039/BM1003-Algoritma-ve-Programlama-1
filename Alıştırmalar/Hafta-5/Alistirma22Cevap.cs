namespace Alistirma22Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1 - 100 arasında kaç asal sayı vardır bulunuz.        
            */
            bool asalmi = true;
            int miktar = 0;
            for (int i = 2; i <= 100; i++)
            {
                asalmi = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        asalmi = false;
                        break;
                    }
                }
                if (asalmi)
                {
                    miktar++;
                }
            }
            Console.WriteLine(miktar);
        }
    }
}
