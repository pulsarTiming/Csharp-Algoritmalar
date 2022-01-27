using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_eleman_haric_sayiların_carpimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liste = new int[5];
            int[] yeniListe = new int[5];

            for (int i = 0; i < liste.Length; i++)
            {
                Console.Write(i + 1 + ". değeri giriniz: ");
                liste[i] = Convert.ToInt16(Console.ReadLine());
            }

            int carpim = 1;
            for(int i = 0; i<5; i++)
            {
                
                for(int j = 0; j<5; j++)
                {
                    
                    if(!(i == j))
                    {
                        carpim = carpim * liste[j];
                    }
                    
                }
                yeniListe[i] = carpim;
                carpim = 1;
            }

            Console.WriteLine("\n***************************\n");

             for(int i = 0; i<liste.Length; i++)
            {
                Console.WriteLine(yeniListe[i]);
            }
            

            Console.ReadKey();
        }
    }
}
