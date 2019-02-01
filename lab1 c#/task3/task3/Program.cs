using System;


namespace task3
{
    class Program
    {
        static void Main()
        {
            int n, i;
            n = Convert.ToInt16(Console.ReadLine());
            int[] ar = new int[n];
            for (i = 0; i < n; i++)
            {
                ar[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Console.Write($"{ar[i]} {ar[i]} "); 
            }
            Console.ReadKey();
        }
    }
}
