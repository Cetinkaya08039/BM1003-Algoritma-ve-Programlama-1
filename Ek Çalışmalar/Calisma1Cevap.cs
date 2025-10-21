namespace Calisma1Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden satır sayısı, sütun sayısı ve bir rakam girildiğinde, girilen değerlere göre ekrana dikdörtgen çerçeve şeklinde bir çıktı veren bir C# programı yazınız.
            Örnek çıktı:
            Satır sayısını giriniz: 5
            Sütun sayısını giriniz: 6
            Hangi sayılardan oluşacağını giriniz: 8
            8 8 8 8 8 8
            8         8
            8         8
            8         8
            8 8 8 8 8 8
            */

            Console.Write("Satır sayısını giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısını giriniz: ");
            int sutun = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hangi sayılardan oluşacağını giriniz: ");
            string sayi = Console.ReadLine();
            string[,] dizi = new string[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (j == 0 || j == (sutun - 1))
                    {
                        dizi[i, j] = sayi;
                    }
                    else if (i == 0 || i == (satir-1))
                    {
                        dizi[i, j] = sayi;
                    }
                    else
                    {
                        dizi[i, j] = " ";
                    }
                        Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
