namespace Alistirma14Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir tam sayı dizisinde yan yana olan iki 5'in sayısını sayan bir C# programı yazın.
            Örnek Giriş :
            { 5, 5, 2 }
            { 5, 5, 2, 5, 5 }
            { 5, 6, 2, 9}
            Beklenen Çıkış :
            1
            2
            0
            */
            Console.Write("Matrisin satır sayısını giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Matrisin sütun sayısını giriniz: ");
            int sutun = Convert.ToInt32(Console.ReadLine());
            int[,] dizi = new int[satir, sutun];
            Random rnd = new Random();
            int[] miktar = new int[satir];
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    dizi[i, j] = rnd.Next(0, 10);
                    Console.Write(dizi[i,j] + " ");
                    if (j > 0 && dizi[i, j] == dizi[i, j-1] && dizi[i,j] == 5)
                    {
                        miktar[i]++;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0;i < satir; i++)
            {
                Console.WriteLine(miktar[i]);
            }
        }
    }
}
