namespace Alistirma19Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan bir sayı alınız. Sayı negatifse işaretini pozitife çevirerek mutlak değerini ekrana yazdırınız.
            */
            Console.Write("Bir sayı giriniz: ");
            double sayi = Convert.ToDouble(Console.ReadLine());

            if (sayi < 0)
            {
                Console.WriteLine("|" + sayi + "|" + " = " + -sayi);
            }
            else
            {
                Console.WriteLine("Sayınız zaten sıfırdan büyük.");
            }
        }
    }
}
