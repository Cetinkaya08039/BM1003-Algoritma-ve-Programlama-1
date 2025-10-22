namespace Alistirma15Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            İki sayıyı değiştirmek için bir C# programı yazınız.
            Test Verileri:
            İlk Sayıyı Girin: 5
            İkinci Sayıyı Girin: 6
            Beklenen Çıktı:
            Değiştirmeden Sonra :
            İlk Sayı : 6
            İkinci Sayı : 5
            */
            Console.Write("İlk sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            double tut = sayi1;
            sayi1 = sayi2;
            sayi2 = tut;
            Console.WriteLine("Değiştirmeden sonra: ");
            Console.WriteLine("İlk sayı: " + sayi1);
            Console.WriteLine("İkinci sayı: " + sayi2);

        }
    }
}
