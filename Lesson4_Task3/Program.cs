// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// мое решение:
// int [] array = new int[8];
// Random myRandom = new Random();
 
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = myRandom.Next(0, 100);
//     Console.Write(array[i] + " ");
// }

// Преподаватель: Тут надо сделать через 2 функции, одна задает массив, вторая его выводит.

// Решение на семинаре:

int[] CreateArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 21);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] arr = CreateArray();
PrintArray(arr);
