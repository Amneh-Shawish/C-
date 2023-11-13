using System;

class PrimeNum
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt(Console.ReadLine());

        bool isPrime = IsPrime(number);

        if (isPrime)
        {
            Console.WriteLine(number + " is prime.");
        }
        else
        {
            Console.WriteLine(number + " is NOT prime.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1){
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}