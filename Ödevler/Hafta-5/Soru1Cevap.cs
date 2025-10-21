namespace Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru:
            5 satır ve 3 sütundan oluşan bir matris (2 boyutlu dizi) oluşturunuz. Matrisi 1 ile 9 arasında rastgele sayılarla doldurunuz. Matrisi yazdırın ve ardından her sütunun toplamını ayrı ayrı gösteriniz.
            Örnek çıktı:
    
            Üretilen matris:
            [3, 7, 2]
            [5, 1, 6]
            [9, 4, 8]
            [2, 9, 1]
            [6, 3, 7]

            Sütun toplamları:

            Sütun 1: 25
            Sütun 2: 24
            Sütun 3: 24
            
            Not:
            Bu uygulamada, başlangıçta sabit boyutlarda tanımlanan matris yapısı yerine, kullanıcıdan satır ve sütun sayılarının dinamik olarak alınması sağlanmıştır. Bu sayede programın esnekliği artırılmış ve farklı boyutlarda matrislerin kolayca oluşturulabilmesi mümkün hale getirilmiştir.
            */

            Console.Write("Satır sayısını giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısını giriniz: ");
            int sutun = Convert.ToInt32(Console.ReadLine());
            int[,] dizi = new int[satir,sutun];
            int[] sutuntoplam = new int[sutun];
            Random rnd = new Random();

            Console.WriteLine("Üretilen matris:");
            for (int i = 0; i < satir; i++)
            {
                Console.Write("[");
                for (int j = 0; j < sutun; j++)
                {
                    
                    dizi[i, j] = rnd.Next(1, 9);
                    if (j == sutun - 1)
                    {
                        Console.Write(dizi[i, j]);
                    }
                    else
                    {
                        Console.Write(dizi[i, j] + ", ");
                    }
                    sutuntoplam[j] += dizi[i, j];
                }
                Console.Write("]");
                Console.WriteLine();

                
            }
            Console.WriteLine();
            Console.WriteLine("Sütun toplamları:");
            for (int i = 0; i < sutuntoplam.Length; i++)
            {
                Console.Write("Sütun " + (i + 1) + ": ");
                Console.Write(sutuntoplam[i] + " ");
                Console.WriteLine();
            }

        }
    }   
}
