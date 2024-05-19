// Без использования функций!

// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

while (true)
{
    Console.Write("Введите целое число (или 'q' для выхода): ");
    string input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    bool isNumber = int.TryParse(input, out int number);
    if (isNumber)
    {
        int sumOfDigits = 0;
        foreach (char digit in input)
        {
            if (char.IsDigit(digit))
            {
                sumOfDigits += digit - '0';
            }
        }

        if (sumOfDigits % 2 == 0)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Пожалуйста, введите корректное целое число.");
    }
}

Console.WriteLine("Программа завершена.");