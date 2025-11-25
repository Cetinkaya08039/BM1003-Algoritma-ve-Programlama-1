namespace Alistirma15Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Belirli bir tamsayı dizisindeki maksimum öğeyi bulan, tüm öğeleri maksimum öğeyle değiştiren bir C# programı yazın.
            Örnek Giriş:
            { 10, 20, -30, -40 }
            Beklenen Çıkış :
            Yeni dizi: 20 20 20 20
            */
            Console.Write("Dizinin uzunluğunu giriniz: ");
            int uzunluk = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[uzunluk];
            Random rnd = new Random();
            Console.Write("Değişimden önce: ");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,101);
                Console.Write(dizi[i] + " ");
            }
            int max = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > max)
                {
                    max = dizi[i];
                }
            }
            Console.Write("\n" + "Yeni dizi: ");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = max;
                Console.Write(dizi[i] + " ");
            }
        }
    }
}
