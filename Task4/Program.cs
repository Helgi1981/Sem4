// Необходимо разделить логику алгоритмов на функции

// Решение с множеством функций:

// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

using System;

class Program
{
    static void Main()
    {
        Run();
    }

    static void Run()
    {
        while (true)
        {
            string input = GetInput();

            if (IsExitCommand(input))
                break;

            if (int.TryParse(input, out int number))
            {
                if (IsSumOfDigitsEven(number))
                    break;
            }
        }

        Console.WriteLine("Программа завершена.");
    }

    static string GetInput()
    {
        Console.Write("Введите целое число или 'q' для выхода: ");
        return Console.ReadLine();
    }

    static bool IsExitCommand(string input)
    {
        return input.Equals("q", StringComparison.OrdinalIgnoreCase);
    }

    static bool IsSumOfDigitsEven(int number)
    {
        int sumOfDigits = CalculateSumOfDigits(number);
        return sumOfDigits % 2 == 0;
    }

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number); // Обработка отрицательных чисел

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}