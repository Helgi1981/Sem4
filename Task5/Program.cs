// Необходимо разделить логику алгоритмов на функции

// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsEven(array[i]))
        {
            count++;
        }
    }

    return count;
}

bool IsEven(int num)
{
    return num % 2 == 0;
}

int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray(arr);

int countEven = CountEvenNumbers(arr);
Console.Write($" => {countEven}");

