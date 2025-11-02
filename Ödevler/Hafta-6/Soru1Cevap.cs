using System.Security.Cryptography;

namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan önce N değerini alın.​
            Ardından N x N boyutunda bir matris oluşturun. Ve elemanlarını -9 ile + 9 arasında(dahil) rastgele oluşturun.​

            Matrisi ekrana yazdırın.​

            Bu matrise bakarak aşağıdaki görevleri yerine getirin:​

            Asal köşegen üzerindeki sayıların toplamını bulun.​

            Yardımcı köşegen üzerindeki sayıların çarpımını bulun.​

            Matrisin içinde kaç adet negatif sayı olduğunu sayın.​

            Matrisin içinde en sık tekrar eden sayıyı bulun.​

            Eğer eşitlik varsa en küçük olanı seçin.​

            Matris içindeki asal sayıların ortalamasını hesaplayın.​

            Asal yoksa: "Asal sayı yok." yazın.​

            Son olarak matrisi saat yönünde 90 derece döndürün ve yeni halini ekrana yazdırın.​
            */

            Console.Write(" N girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[n, n];
            Random rnd = new Random();
            // Birden fazla satır atlatma olayını("\n\n") birden fazla Console.Writeline() kullanmak yerine bir alternatif araştırarak bulup yaptım.
            Console.WriteLine("\n\n" + " Oluşturulan Matris:");
            int asalkosegentoplam = 0;
            int yardimcikosegencarpim = 1;
            int negatifmiktar = 0;
            int[,] matris90 = new int[n, n];
            double asaltoplam = 0;
            int asalmiktar = 0;
 

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matris[i, j] = rnd.Next(-9, 9);

                    // Yazdırılan matris daha düzgün gözükmesi adına $"{matris[i,j],4}" kısmını araştırarak yaptım.
                    Console.Write($"{matris[i, j],4}");

                    if (j == i)
                    {
                        asalkosegentoplam += matris[i, j];
                    }
                    if (matris[i,j] < 0)
                    {
                        negatifmiktar++;
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write(" Ana köşegen toplamı: ");
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {

                    if (j == i)
                    {
                        if (j == n-1)
                        {
                            Console.Write(matris[i, j] + " = " + asalkosegentoplam);
                            Console.WriteLine();

                        }
                        else
                        {
                            Console.Write(matris[i, j] + " + ");

                        }
                    }
                }
            }
            Console.Write(" Yardımcı köşegen çarpımı: ");
            for (int i = n-1; i >=0 ; i--)
            {
                for(int j = n-1; j >= 0; j--)
                {
                    if (i+j == n-1)
                    {
                        // paint üzerinden matris numaralarını çizdim(0,0 , 0,1 gibi) yardımcı köşegen üzerinde olan sayıları gözlemlediğimde
                        // matrisin boyutu fark etmeksizin bu sayıların toplamının n sayısından bir eksik olduğunu gözlemledim.
                        yardimcikosegencarpim = yardimcikosegencarpim * matris[i, j];
                        if (j == n - 1)
                        {
                            Console.Write(matris[i, j] + " = ");

                        }
                        else
                        {
                            Console.Write(matris[i, j] + " * ");
                        }
                    } 

                }
            }
            Console.Write(yardimcikosegencarpim + "\n");
            Console.WriteLine(" Negatif sayı adedi: " + negatifmiktar);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matris[i,j] == 2 || matris[i, j] == 3 || matris[i, j] == 5 || matris[i, j] == 7)
                    {
                        asaltoplam += matris[i, j];
                        asalmiktar++;

                    }
                }
            }
            int index = 0;
            int[] asal = new int[asalmiktar];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matris[i, j] == 2 || matris[i, j] == 3 || matris[i, j] == 5 || matris[i, j] == 7)
                    {
                        asal[index] = matris[i, j];
                        index++;
                    }
                }
            }
            
            if (asalmiktar != 0)
            {
                Console.Write(" Asal sayıların ortalaması: (");
                for (int i = 0; i < asalmiktar; i++)
                {
                    if (i == asalmiktar - 1)
                    {
                        Console.Write(asal[i] + ") / " + asalmiktar + " = " + asaltoplam / asalmiktar + "\n\n");
                    }
                    else
                    {
                        Console.Write(asal[i] + " + ");
                    }
                }
            }
            else
            {
                Console.WriteLine(" Asal sayı yok.");
            }

                Console.WriteLine(" Saat yönünde 90 derece döndürülmüş:");
            for(int i = 0; i < n; i++)
            {
                for (int j = n-1; j >= 0; j--)
                {


                    matris90[i, j] = matris[j, i];
                    Console.Write($"{matris90[i, j],4}");

                }
                Console.WriteLine();
            }

        }
    }
}
