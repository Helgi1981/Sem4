// Необходимо разделить логику алгоритмов на функции

// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

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

void ReverseArray(int[] array)
{
    int left = 0;
    int right = array.Length - 1;

    while (left < right)
    {
        int temp = array[left];
        array[left] = array[right];
        array[right] = temp;

        left++;
        right--;
    }
}

int[] arr = CreateArrayRndInt(10, 1, 10);
Console.WriteLine("Original Array:");
PrintArray(arr);

ReverseArray(arr);
Console.WriteLine("\nReversed Array:");
PrintArray(arr);