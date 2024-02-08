// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array ={1, 5, 8, 0, 9, 52};
PrintArray(array);
Console.Write($" => ");
PrintReverseArray(array, 0);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);

        }
        else
        {
            Console.Write(array[i] + " ");
        }

    }
    Console.Write("]");
}

void PrintReverseArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        Console.Write(array[i] + " ");
        return;
    }

    PrintReverseArray(array, i + 1);
    Console.Write(array[i] + " ");
}


