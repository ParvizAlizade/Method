using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir soz daxil edin");
            string a = Console.ReadLine();
            Console.WriteLine("Bir simvol ve ya herf daxil edin:");
            char b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(FindCharIndex(a, b));
        }
        static int FindCharIndex(string a,char b)
        {
          
            for (int i = 0; i <a.Length ; i++)
            {
                if (a[i]==b)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
