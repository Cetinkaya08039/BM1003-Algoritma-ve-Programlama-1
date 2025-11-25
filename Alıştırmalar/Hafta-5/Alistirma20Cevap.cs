namespace Alistirma20Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Girilen bir sayının 5’in kuvveti olup olmadığını hesaplayınız.
            Örnek:
            125-> 5’in kuvvetidir.
            10-> 5’in kuvveti değildir
            */
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool kuvvet = false;
            while (true)
            {
                for (int i = 0; i < (int)(Math.Sqrt(sayi)); i++)
                {
                    if (Math.Pow(5, i) == sayi)
                    {
                        Console.WriteLine(sayi + "-> 5'in kuvvetidir.");
                        kuvvet = true;
                        break;
                    }
                }
                if (kuvvet) { break; }
                Console.WriteLine(sayi + "-> 5'in kuvveti değildir.");
                break;
            }

        }
    }
}
