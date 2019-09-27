using System;

namespace metod_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            byt(ref a, ref b);
            Console.WriteLine(a + " " + b);

        }
        public static void byt(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
