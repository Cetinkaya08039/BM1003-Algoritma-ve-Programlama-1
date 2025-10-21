namespace Alistirma7Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Belirli bir sayının faktöriyelini hesaplayan bir C# programı yazın.
            */

            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            Console.WriteLine(sayi + "! = " + faktoriyel);
        }
    }
}
