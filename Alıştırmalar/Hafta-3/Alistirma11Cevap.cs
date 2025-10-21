namespace Alistirma11Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan iki sayı ve bir işlem(+, -, *, /) seçmesini isteyen, buna göre sonucuhesaplayan programı yazınız.
            */

            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yapacağınız işlemi giriniz(+, -, *, /): ");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Console.WriteLine(sayi1 + " + " + sayi2 + " = " + (sayi1+sayi2));
            }
            else if (islem == "-")
            {
                Console.WriteLine(sayi1 + " - " + sayi2 + " = " + (sayi1 - sayi2));
                Console.WriteLine(sayi2 + " - " + sayi1 + " = " + (sayi2 - sayi1));
            }
            else if (islem == "*")
            {
                Console.WriteLine(sayi1 + " * " + sayi2 + " = " + (sayi1 * sayi2));

            }
            else if (islem == "/")
            {
                Console.WriteLine(sayi1 + " / " + sayi2 + " = " + (sayi1 / sayi2));
                Console.WriteLine(sayi2 + " / " + sayi1 + " = " + (sayi2 / sayi1));
            }
            else
            {
                Console.WriteLine("Hata!");
            }
        }
    }
}
