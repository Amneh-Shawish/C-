using System;

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("Enter the value of Fn: ");
        int Fn = Convert.ToInt(Console.ReadLine());

        int result = Fibonacci(Fn);

        Console.WriteLine("The Fibonacci Sequence of " + Fn + " is: " + result);
    }

    static int Fibonacci(int Fn)
    {
        if (Fn <= 1){
            return Fn;
        }

        int prev = 0;
        int current = 1;
        int fib = 0;

        for (int i = 2; i <= Fn; i++)
        {
            fib = prev + current;
            prev = current;
            current = fib;
        }

        return fib;
    }
}