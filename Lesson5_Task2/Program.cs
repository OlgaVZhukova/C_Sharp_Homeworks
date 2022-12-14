// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int length, int minLimit, int maxLimit)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

// Мой вариант решения:
// int SumOdd(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

//Комментарий проподавателя: Лучше вот так:

int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] arr = CreateArray(4, -100, 100);
PrintArray(arr);
int result = SumOdd(arr);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива: {result}.");
