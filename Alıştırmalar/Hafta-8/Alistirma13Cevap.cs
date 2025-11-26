namespace Alistirma13Cevap
{
    internal class Program
    {
        static double[] dac(double yc)
        {
            double[] ac = new double[2];
            // A = Pi*r*r
            // Ç = 2*Pi*r
            ac[0] = Math.PI*yc*yc;
            ac[1] = 2*Math.PI*yc;
            return ac;
        }
        static void Main(string[] args)
        {
            /*
            Yarıçapı parametre olarak alan bir dairenin alanını ve çevresini hesaplayan bir metot yazınız.
            */
            Console.Write("Dairenin yarıçapını giriniz:");
            double yc = Convert.ToInt32(Console.ReadLine());
            double[] ac = dac(yc);
            Console.WriteLine("Dairenin alanı:" + ac[0]);
            Console.WriteLine("Dairenin çevresi:" + ac[1]);

        }
    }
}
