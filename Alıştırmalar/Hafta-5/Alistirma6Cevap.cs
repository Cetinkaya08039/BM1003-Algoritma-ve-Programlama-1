namespace Alistirma6Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            0 ve 100 arasındaki rastgele sayılarla oluşturulan 20 elemanlı bir dizinin elemanlarının, 
            50’den büyük olanların toplamının 50'den küçük olanların toplamına oranını hesaplayınız.
            */
            int[] dizi = new int[20];
            Random rnd = new Random();
            double mintoplam = 0;
            double maxtoplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,100);
                if (dizi[i] >= 50)
                {
                    maxtoplam += dizi[i];
                }
                else
                {
                    mintoplam += dizi[i];
                }
            }
            Console.WriteLine("50'den büyük olanların toplamının 50'den küçük olanların toplamına oranı: " + maxtoplam/mintoplam);
        }
    }
}
