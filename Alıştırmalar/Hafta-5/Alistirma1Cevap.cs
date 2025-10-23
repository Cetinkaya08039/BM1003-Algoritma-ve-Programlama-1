namespace Alistirma1Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10 elemanı bir tam sayı dizisini kullanıcıdan alınan değerlerle dolduran ve dizideki elemanları yazdıran kodu yazınız.
            */

            double[] dizi = new double[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("Dizinin " + (i+1) + ". elemanını giriniz: ");
                dizi[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }

        }
    }
}
