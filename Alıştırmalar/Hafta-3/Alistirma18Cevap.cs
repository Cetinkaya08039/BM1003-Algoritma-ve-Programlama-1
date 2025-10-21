namespace Alistirma18Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            3 dersten alınan notların ortalamasını bulan ve ortalama 50’nin altındaysa “Kaldı”, aksi halde “Geçti” yazan programı yazınız.
            */
            Console.Write("1. dersten aldığınız notu giriniz: ");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. dersten aldığınız notu giriniz: ");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. dersten aldığınız notu giriniz: ");
            double not3 = Convert.ToDouble(Console.ReadLine());
            double ort = (not1 + not2 + not3) / 3;
            if (ort < 50)
            {
                Console.WriteLine("Ortalamanız " + ort + " olduğundan kaldınız.");
            }
            else
            {
                Console.WriteLine("Geçtiniz!");
            }
        }
    }
}
