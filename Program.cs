using System;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            bool check = true;
            int number;

            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }

            if (check)
                Console.WriteLine(number + " is a prime.");
            else
                Console.WriteLine(number + " is not a prime.");
        }
    }
}
