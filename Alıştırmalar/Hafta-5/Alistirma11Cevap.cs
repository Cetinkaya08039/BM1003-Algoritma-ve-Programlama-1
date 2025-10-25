namespace Alistirma11Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            2x3 boyutunda bir matris oluşturup, dışarıdan değer girilen ve matrisi ekrana yazdıran bir program yazınız.
            */

            int[,] matris = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Matrisin " + (i+1) + ". satır " + (j+1) + ". sütununun elemanını giriniz: ");
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matris:");
            for (int i = 0;i < 2;i++)
            {
                Console.Write("[");
                for(int j = 0;j < 3;j++)
                {
                    if (j == 2)
                    {
                        Console.Write(matris[i, j]);

                    }
                    else
                    {
                        Console.Write(matris[i, j] + " ");
                    }
                }
                Console.Write("]");
                Console.WriteLine();
            }


        }
    }
}
