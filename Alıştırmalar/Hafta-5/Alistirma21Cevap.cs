namespace Alistirma21Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10 ve 50 arasındaki asal sayıları bulunuz.
            */
            bool asalmi = true;
            for (int i = 10; i <= 50; i++)
            {
                asalmi = true;
                for (int j = 2; j < Math.Sqrt(i); j++)
                {
                    if (i%j == 0)
                    {
                        asalmi = false;
                        break;
                    }
                }
                if (asalmi)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
