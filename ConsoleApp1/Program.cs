using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int val;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    val = i * j;
                    System.Console.Write(i + "X" + j + "=");
                    System.Console.Write("{0,3}", val.ToString() + " ");
                }
                System.Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
