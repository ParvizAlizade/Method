using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fenn sayini daxil et:");
            int fennsayi = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[fennsayi];
           
            int ortabal = CalcAvg(arr);
            if (ortabal > 60)
            {
                Console.WriteLine("Mezun ola bildiz");
            
            }
            else
            {
                Console.WriteLine("Kesildiniz");
            }
        }
        static int CalcAvg(int[] a)
        {
            int cem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                cem += a[i];
            }
            return cem / a.Length;
        }
    }
} 


