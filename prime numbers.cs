using System;

public class prime
{
   static bool Prime(long n)
        {

            for (int i = 2; i * i <= n; i++)
            {

                if (n % i == 0)
                    return false;

            }
            return true;
        }
        static void Main(string[] args)
        {
            long n1, n2;

            Console.WriteLine("enter the first number");
            n1 = long.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number");
            n2 = long.Parse(Console.ReadLine());

            if (n1 <= 1)
                n1 = 2;

            for (long i = n1; i <= n2; i++)
            {

                if (Prime(i))
                {

                    Console.WriteLine(i);

                }

            }

        }
}