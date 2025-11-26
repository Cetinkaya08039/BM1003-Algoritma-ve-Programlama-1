namespace Alistirma20Cevap
{
    internal class Program
    {
        static void mt(int[,] matris)
        {
            Console.WriteLine("Matris:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matris[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrisin Transpozu:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matris[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            /*
            2x2 boyutunda bir matrisi parametre olarak alan ve transpozunu alıp sonucu geriye döndüren bir metot yazınız.
            */
            Random rnd = new Random();

            int[,] matris = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matris[i,j] = rnd.Next(1,10);
                }
            }
            mt(matris);
        }
    }
}
