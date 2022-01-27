using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();

            Console.Write("matrisiniz için birinci sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("matrisiniz için ikinci sayıyı giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] ddizi = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    ddizi[i, j] = rndm.Next(0, 2);
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(ddizi[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == 1)
                    {
                        if (j != 0 && j != (y - 1))
                        {
                            if (i == 1 && j == 1)
                            {
                                if ((i == 0 && j == 1) || (i == 1 && j == 0))
                                {
                                    ddizi[i, j] = 0;
                                }
                            }

                            if (i == 1 && j == (y - 2))
                            {
                                if ((i == 0 && j == (y - 2)) || (i == 1 && j == (y - 1)))
                                {
                                    ddizi[i, j] = 0;
                                }
                            }

                            if (ddizi[0, j] == 1)
                            {
                                ddizi[i, j] = 0;
                            }
                        }
                    }
                    if (i == (x - 2))
                    {
                        if (j != 0 && j != (y - 1))
                        {
                            if (i == (x - 2) && j == 1)
                            {
                                if ((ddizi[x - 2, 0] == 1) || ddizi[x - 1, 1] == 1)
                                {
                                    ddizi[i, j] = 0;
                                }
                            }
                            if ((i == (x - 2)) && (j == (y - 2)))
                            {
                                if (ddizi[x - 2, y - 1] == 1 || ddizi[x - 1, y - 2] == 1)
                                {
                                    ddizi[i, j] = 0;
                                }
                            }

                            if (ddizi[x - 1, j] == 1)
                            {
                                ddizi[i, j] = 0;
                            }
                        }
                    }
                    if (j == 1 && i != 0 && i != (x - 1))
                    {
                        if (ddizi[i, 0] == 1)
                        {
                            ddizi[i, j] = 0;
                        }
                    }
                    if (j == (y - 2) && i != 0 && i != (x - 1))
                    {
                        if (ddizi[i, y - 1] == 1)
                        {
                            ddizi[i, j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(ddizi[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadKey();

        }
    }
}

