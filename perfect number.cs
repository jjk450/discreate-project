using System;
public class perfectn
{
    public static void Main()
    {
        
        int n, i, sum;
        int m, x;
        
        Console.Write("Find the perfect number between two numbers from the user:\n");
        
        Console.Write("\n\n");

        Console.Write("Enter First Number : ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("The perfect number between the two numbers is : ");
        for (n = m; n <= x; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.Write("{0} ", n);
        }
        Console.Write("\n");
    }
}