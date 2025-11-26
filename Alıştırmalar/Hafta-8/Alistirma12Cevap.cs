namespace Alistirma12Cevap
{
    internal class Program
    {
        static double btod(string xstr)
        {

            int xlength = xstr.Length;
            bool binarymi = true;
            double dec = 0;
            for (int i = xlength - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(xstr.Substring(i, 1)) != 1 && Convert.ToInt32(xstr.Substring(i, 1)) != 0)
                {
                    binarymi = false;
                    break;
                }
                if (binarymi)
                {
                    dec += Convert.ToInt32(xstr.Substring(i, 1)) * Math.Pow(2, xlength - 1 - i);
                }

            }
            if (!binarymi)
            {
                Console.WriteLine("İkili sistemden bir sayı girmeniz gerekmekte!");
                return -1;
            }
            else
            {
                return dec;
            }
        }
        static void Main(string[] args)
        {
            /*
            Parametre olarak ikili bir sayıyı alan ve bu sayıyı onluk tabana dönüştüren bir metot yazınız.
            Örnek:
            101-> 5
            */
            Console.Write("İkili sistemden bir sayı girin: ");
            string xstr = Console.ReadLine();
            Console.WriteLine(btod(xstr));
        }
    }
}
