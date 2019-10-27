using System;

namespace Lab_02_8program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("write a and b (a < b)");
                Console.Write("a: ");
                int a = Int32.Parse(Console.ReadLine());
                Console.Write("b: ");
                int b = Int32.Parse(Console.ReadLine());
                int sum = 0;
                if (a < b)
                {
                    for (; a < b; a++)
                    {
                        if (a % 2 != 0)
                            sum += a;
                        else
                            continue;
                    }
                    Console.WriteLine($"The result's {sum}");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("a > b or a = b. Try again");
                    Console.ReadKey();
                    Program.Main(args);
                }
                Console.ReadKey();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error.. Try again");
                Console.ReadKey();
                Program.Main(args);
            }
        }
    }
}
