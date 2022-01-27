using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhangi_iki_sayinin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kaç sayı girmek istersiniz: ");
            int tane = Convert.ToInt16(Console.ReadLine());

            int[] liste = new int[tane];
            for(int i = 0; i<tane; i++)
            {
                Console.Write((i + 1)+ ". sayıyı girin: ");
                liste[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("aradığınız sayıyı giriniz: ");
            int aranan = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i<tane; i++)
            {
                for(int j = (i+1); j < tane; j++)
                {
                    if(liste[i] + liste[j] == aranan)
                    {
                        Console.WriteLine(aranan + " sayısı listenin elemanlarından ikisinin toplamıdır. Bunlar = " + liste[i] + " ve " + liste[j]);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
