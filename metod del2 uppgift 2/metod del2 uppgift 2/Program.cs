using System;

namespace metod_del2_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en bas");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange en exponenet");
            int exponent = int.Parse(Console.ReadLine());
            power(bas, exponent);
            Console.WriteLine(power(bas, exponent));
         }


        static public int power(int b ,int e)
        {
            return (b * e);
        }

    }
}
