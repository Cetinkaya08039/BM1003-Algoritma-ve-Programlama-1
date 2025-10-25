namespace Alistirma3Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Rastgele sayılarla oluşturulan 20 elemanlı bir dizinin çift olanlarının toplamının tek olanlarının toplamına oranını bulunuz.
            */

            int[] dizi = new int[20];
            double cifttoplam = 0;
            double tektoplam = 0;
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,20);
                if (dizi[i] %2 == 0)
                {
                    cifttoplam += dizi[i];
                }
                else
                {
                    tektoplam += dizi[i];
                }
            }
            Console.WriteLine("Çift olan sayıların toplamı: " + cifttoplam);
            Console.WriteLine("Tek olan sayıların toplamı: " + tektoplam);
            Console.WriteLine("Çift olan sayıların toplamının tek olan sayıların toplamına oranı: " + cifttoplam/tektoplam);
        }
    }
}
