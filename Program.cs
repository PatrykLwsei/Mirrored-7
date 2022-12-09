using System;

namespace Mirroed_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int g = n;
            int i, j, k, z = 0;
            for (i = 0; i < g; i++)
            {
                Console.Write("*");
            }
            
            for (j = 0; j < g; j++)
            {
                for (k = 0; k < j; k++)
                {
                    Console.Write(" ");
                }
                
                for (z = 0; z < k; z+=k)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}