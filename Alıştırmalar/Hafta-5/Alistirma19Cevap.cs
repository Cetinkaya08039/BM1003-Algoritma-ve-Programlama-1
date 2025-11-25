namespace Alistirma19Cevap.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10 ile 1000 arasındaki tam kare sayıları ekrana yazdıran programı yazınız. (Tam kare, karekökü
            bir doğal sayı olan tam sayılara denir. 0, 1, 4, 9, 16, 25, 36, 49... tam kare sayılara örnektir.)
            */
            for (int i = 0; i <= 1000; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (Math.Sqrt(i) == j)
                    {
                        Console.Write(i + " ");
                    }

                }

            }


        }
    }
}
