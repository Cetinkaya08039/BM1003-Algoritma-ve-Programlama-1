namespace Alistirma6Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Sıcaklığı santigrat cinsinden okumak ve aşağıdaki sıcaklık durumuna göre uygun bir mesaj
            görüntülemek için programı yazın:
            Sıcaklık < 0, ardından Dondurucu hava
            Sıcaklık 0-10, ardından Çok Soğuk hava
            Sıcaklık 10-20, ardından Soğuk hava
            Sıcaklık 20-30 ve ardından Normal Sıcaklık
            Sıcaklık 30-40 sonra Sıcak
            Sıcaklığı >=40 sonra Çok Sıcak
            */
            Console.Write("Hava sıcaklığını santigrat cinsinden giriniz: ");
            double sicaklik = Convert.ToDouble(Console.ReadLine());
            if (sicaklik < 0)
            {
                Console.WriteLine("Dondurucu hava!");
            }
            else if (0 <= sicaklik && sicaklik < 10)
            {
                Console.WriteLine("Çok soğuk hava!");
            }
            else if (10 <= sicaklik && sicaklik < 20)
            {
                Console.WriteLine("Soğuk hava!");
            }
            else if (20 <= sicaklik && sicaklik < 30)
            {
                Console.WriteLine("Normal sıcaklık!");
            }
            else if (30 <= sicaklik && sicaklik < 40)
            {
                Console.WriteLine("Sıcak!");
            }
            else if (40 <= sicaklik )
            {
                Console.WriteLine("Çok sıcak!");
            }
            else
            {
                Console.WriteLine("Hata!");
            }
        }
    }
}
