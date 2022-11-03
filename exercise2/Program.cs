using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    { private int[] a = new int[27];
    private int n;

        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan banyak elemen pada array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 27)
                    break;
                else
                    Console.WriteLine("\nArray maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("Masukkan Element Array");
            Console.WriteLine("----------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
