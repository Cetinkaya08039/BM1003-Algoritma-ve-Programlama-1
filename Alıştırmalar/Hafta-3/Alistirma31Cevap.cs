namespace Alistirma31Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Beden Kitle İndeksi (BMI): boy (m) ve kilo alın. BMI = kilo/(boy²). <18.5 → Zayıf, 18.5–24.9 → Normal, 25–29.9 → Fazla Kilolu, ≥30 → Obez.
            */

            Console.Write("Boy uzunluğunuzu metre cinsinden giriniz(örn: 1,75): ");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu giriniz: ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            double BMI = kilo / (boy * boy);
            if (BMI < 18.5) 
            {
                Console.WriteLine("BMI = " + BMI + " -> Zayıf");
            }
            else if (18.5 <= BMI && BMI <= 24.9)
            {
                Console.WriteLine("BMI = " + BMI + " -> Normal");
            }
            else if (25 <= BMI && BMI <= 29.9)
            {
                Console.WriteLine("BMI = " + BMI + " -> Fazla Kilolu");
            }
            else
            {
                Console.WriteLine("BMI = " + BMI + " -> Obez");
            }
        }
    }
}
