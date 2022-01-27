using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//isim ve soy ismin karakter uzunluğu 12 olacak şekilde düzenleyip, bunu U ve kare şekllinde yazdırır.
namespace cSharpVize
{

    class Program
    {
        static void Main(string[] args)
        {
            string isim, soyisim;
            Console.Write("isminizi giriniz: ");
            isim = Console.ReadLine();

            Console.Write("soy isminizi giriniz: ");
            soyisim = Console.ReadLine();

            if (!(isim.Length % 12 == 0))
            {
            tekrar:
                isim = isim + "*";
                if (!(isim.Length % 12 == 0))
                {
                    goto tekrar;
                }

            }



            if (!(soyisim.Length % 12 == 0))
            {
            tekrar1:
                soyisim = soyisim + "+";
                if (!(soyisim.Length % 12 == 0))
                {
                    goto tekrar1;
                }
            }

            Console.WriteLine(isim);
            Console.WriteLine(soyisim);

            int soyKarakter = (soyisim.Length) / 3;

            int k = 0;
            int l = 1;

            for (int i = 0; i <= soyKarakter; i++)
            {
                for (int j = 0; j < soyKarakter; j++)
                {
                    if (i != soyKarakter)
                    {
                        if (j == 0)
                        {
                            Console.Write(soyisim[k]);
                            k++;
                        }
                        else if (j == soyKarakter - 1)
                        {
                            Console.Write(soyisim[(soyisim.Length - l)]);
                            l++;
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {

                        Console.Write(soyisim[k]);
                        k++;
                    }
                }

                Console.WriteLine();
            }



            int isimKarakter = isim.Length / 4;
            k = isimKarakter;
            l = isim.Length - 1;

            for (int i = 1; i <= (isimKarakter + 2); i++)
            {
                for (int j = 0; j < isimKarakter; j++)
                {
                    if (i == 1)
                    {
                        Console.Write(isim[j]);
                    }

                    else if (j == 0)
                    {
                        Console.Write(isim[k]);
                        k++;
                    }
                    else if (j == isimKarakter - 1)
                    {
                        Console.Write(isim[l]);
                        l--;
                    }
                    else if (i == isimKarakter + 2)
                    {
                        Console.Write(isim[k]);
                        k++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }



            Console.ReadKey();


        }
    }
}
