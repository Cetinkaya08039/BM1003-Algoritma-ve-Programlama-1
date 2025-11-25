namespace Alistirma8Cevap
{
    internal class Program
    {
        static void faktoriyel()
        {
            Console.Write("Faktöriyeli alınacak sayıyı girin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int carp = 1;
            for (int i = 1; i <= x; i++)
            {
                carp *= i;
            }
            Console.WriteLine(x + "! = " + carp);

        }
        static void Main(string[] args)
        {
            /*
            Bir sayıyı parametre olarak alan ve bu sayının faktöriyelini hesaplayıp sonucu geri döndüren bir metot tanımayız.
            */
            faktoriyel();
        }
    }
}
