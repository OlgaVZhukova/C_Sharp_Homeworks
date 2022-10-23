// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = CreateArray(3, 4);
PrintArray(array);

// double Average(int[,] array)
double[] averageNumbers = new double[array.GetLength(1)];
// {
    // double sum = 0;
    // double[] averageNumbers = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0.0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        averageNumbers[i] = sum / array.GetLength(0);
    }
    // return averageNumbers;
// }

void PrintArrayAverage(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write(array[i] + " ");
    }
        System.Console.WriteLine();
}

// int[,] array = CreateArray(3, 4);
// PrintArray(array);
PrintArrayAverage(averageNumbers);
System.Console.WriteLine();
// System.Console.WriteLine($"Среднее арифметическое каждого столбца: {result}");
System.Console.WriteLine(averageNumbers);


