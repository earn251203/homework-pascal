using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int input = ReadIntegerInput();
            if (input < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
            }
            else
            {
                PrintPascalsTriangle(input);
                break;
            }
        }
    }

    static int ReadIntegerInput()
    {
        int input = int.Parse(Console.ReadLine());
        return input;
    }

    static void PrintPascalsTriangle(int rows)
    {
        for (int row = 0; row <= rows; row++)
        {
            for (int column = 0; column <= row; column++)
            {
                int coefficient = CalculateCoefficient(row, column);
                Console.Write("{0} ", coefficient);
            }
            Console.WriteLine();
        }
    }

    static int CalculateCoefficient(int row, int column)
    {
        int numerator = Factorial(row);
        int denominator = Factorial(row - column) * Factorial(column);
        int coefficient = numerator / denominator;
        return coefficient;
    }

    static int Factorial(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

                   