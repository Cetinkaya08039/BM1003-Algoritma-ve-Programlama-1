namespace Alistirma16Cevap.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            3'lerin sayısının 5'lerden büyük olup olmadığını kontrol eden bir C# Sharp programı yazın.
            Örnek Giriş :
            { 1, 5, 6, 9, 3, 3 }
            { 1, 5, 5, 5, 10, 17 }
            { 1, 3, 3, 5, 5, 5}
            Beklenen Çıktı :
            Doğru
            Yanlış
            Yanlış
            */
            Console.Write("Matrisin satır sayısını giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Matrisin sütun sayısını giriniz: ");
            int sutun = Convert.ToInt32(Console.ReadLine());
            int[,] dizi = new int[satir, sutun];
            Random rnd = new Random();
            int[,] miktar = new int[satir,2];
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    dizi[i, j] = rnd.Next(0, 10);
                    Console.Write(dizi[i, j] + " ");
                    if (dizi[i,j] == 3)
                    {
                        miktar[i, 0]++;
                    }
                    else if (dizi[i, j] == 5)
                    {
                        miktar[i, 1]++;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < satir; i++)
            {
                if (miktar[i,0] > miktar[i,1])
                {
                    Console.WriteLine("Doğru");
                }
                else
                {
                    Console.WriteLine("Yanlış");
                }
            }
        }
    }
}
