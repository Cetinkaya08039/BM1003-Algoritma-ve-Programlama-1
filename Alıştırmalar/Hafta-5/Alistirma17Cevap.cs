namespace Alistirma17Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Tüm 5 değerlerini 0 ile değiştirdikten sonra tüm sıfırları sağa kaydırarak yeni bir dizi oluşturan bir C# programı yazın.
            Örnek Giriş:
            { 1, 2, 5, 3, 5, 7, 5, 9, 11 }
            Beklenen Çıkış :
            Yeni dizi: 1 2 3 7 9 11 0 0 0
            */
            Console.Write("Dizinin uzunluğunu giriniz: ");
            int uzunluk = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[uzunluk];
            Random rnd = new Random();
            Console.Write("Değişimden önce: ");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,10);
                Console.Write(dizi[i] + " ");
                if (dizi[i] == 5)
                {
                    dizi[i] = 0;
                }
            }
            Console.Write("\n" + "Yeni dizi: ");
            int[] yenidizi = new int[uzunluk];
            int indis = 0;
            for (int i = 0;i < yenidizi.Length;i++)
            {
                if (dizi[i] != 0)
                {
                    yenidizi[indis] = dizi[i];
                    indis++;
                }
            }
            for (int i = 0; i < yenidizi.Length; i++)
            {
                Console.Write(yenidizi[i] + " ");
            }
        }
    }
}
