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
                Console.Write("Masukkan banyak elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 27)
                    break;
                else
                    Console.WriteLine("\nArray maksimal 27 elemen.\n");
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
        
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Element Array Telah Tersusun");
            Console.WriteLine("----------------------------");
            for (int RA = 0; RA < n; RA++)
            {
                Console.WriteLine(a[RA]);
            }
            Console.WriteLine();
        }
        public void InsertionSort()
        {
            for (int i = 0; i < n; i++)
            {
                int temp = a[i];
                int RA = i - 1;
                while(RA>=0 && a[RA] > temp)
                {
                    a[RA - 1] = a[RA];
                    RA--;
                }
                a[RA + 1] = temp;
            }
        }
        
        static void Main(string[] args)
        {

        }
    }
}
