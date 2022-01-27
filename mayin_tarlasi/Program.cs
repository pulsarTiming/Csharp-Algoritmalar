using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpVize0
{
    class Program
    {
        static void Main(string[] args)
        {
            int satır, sütun;
            Console.Write("satır sayısını giriniz: ");
            satır = Convert.ToInt16(Console.ReadLine());

            Console.Write("sütun sayısını giriniz: ");
            sütun = Convert.ToInt16(Console.ReadLine());


            int[,] matris = new int[satır, sütun];
            Random rndm = new Random();


            /*for (int i = 0; i<satır; i++)
            {
                for (int j = 0; j< sütun; j++)
                {
                    matris[i, j] = rndm.Next(0, 2);
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            int puan = 0;

            Console.WriteLine("*************************************************");
        tekrar:
            Console.Write("seçmek istediğiniz satırı giriniz: ");
            satır = Convert.ToInt16(Console.ReadLine());
            Console.Write("seçmek istediğiniz sütunu giriniz: ");
            sütun = Convert.ToInt16(Console.ReadLine());


            
            if(matris[satır-1, sütun-1] == 1)
            {
                puan += 10;
                Console.WriteLine("tebrikler! hala hayattasın.");
                goto tekrar;
            }
            else
            {
                Console.WriteLine("good game. puanınız: " + puan);
            }
            Console.ReadKey();

        }

    }
}
