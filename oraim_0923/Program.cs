using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraim_0923
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            bool y = false;

            /* ==  --akkor igaz, ha mindkettö igaz vagy mindkettő hamis (ha egyformák az operandusok)
             * !=  --(kizáró vagy) akkor igaz, ha az egyik igaz a másik hamis (ha különbözőek az operandusok)
             * ||  --akkor igaz, ha legalláb az egyik igaz  
             * &&  --akkor igaz, ha mindkettő igaz */

            int[] t = new int[10];

            if ((t.Length == 7) == (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday))
            {
                Console.WriteLine("Belefér.");
            }
            else
            {
                Console.WriteLine("Faszsag.");
            }

            int z = 10;
            switch (z)
            {
                case 1:
                    {
                        Console.WriteLine("ez 1");
                        Console.WriteLine("további");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Ez 2");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Ez 5");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("három");
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Tíz");
                    }
                    break;
                default:
                    Console.WriteLine("Egyik se");
                    break;
            }

            Console.ReadKey();
        }
    }
}
