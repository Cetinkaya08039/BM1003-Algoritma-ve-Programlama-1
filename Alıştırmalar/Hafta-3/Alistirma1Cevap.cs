namespace Alistirma1Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Klavyeden girilen 3 sayıyı küçükten büyüğe doğru ekrana yazan programı yazınız.
            */
            Console.Write("1. sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. sayıyı giriniz: ");
            double sayi3 = Convert.ToDouble(Console.ReadLine());
            
            double enkucuk = Math.Min(sayi1, Math.Min(sayi2,sayi3));
            double enbuyuk = Math.Max(sayi1, Math.Max(sayi2, sayi3));
            double ortanca = (sayi1 + sayi2 + sayi3) - (enkucuk + enbuyuk);
            Console.Write(enkucuk + ", ");
            Console.Write(ortanca +", ");
            Console.Write(enbuyuk);
        }
    }
}
