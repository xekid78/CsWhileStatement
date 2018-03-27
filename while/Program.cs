using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** ケース１ **");
            var i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i + "だよ。");
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("** ケース２ **");
            i = 5;
            while (i >= 1)
            {
                Console.WriteLine(i + "だよ。");
                i--;
            }    
        }
    }
}
