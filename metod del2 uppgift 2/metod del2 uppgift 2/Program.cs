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
            Console.WriteLine("Svaret bli: " + power(bas, exponent));
         }


        static public int power(int b ,int e)
        {
          int resultat = 1;
          for(int i = 0; i < e; i++)
          {
            resultat = resultat * b;

          }
          return resultat;
        }

    }
}
