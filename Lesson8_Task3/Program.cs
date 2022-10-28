// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

int quantityRow = Prompt("Введите количество строк матрицы: ");
int quantityColumn = Prompt("Введите количество столбцов матрицы: ");
int[,] array = CreateArray(quantityRow, quantityColumn);
int[,] secondArray = CreateArray(quantityRow, quantityColumn);
PrintArray(array);
System.Console.WriteLine();
PrintArray(secondArray);

int[,] ProductArrays(int quantityRow, int quantityColumn)
{
    int[,] resultArray = new int[quantityRow, quantityColumn]; //new array[int quantityRow, int quantityColumn]
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                for (int l = 0; l < secondArray.GetLength(1); l++)
                {
                    resultArray[i, j] = array[i, j] * secondArray[i, j];
                }
            }
        }
    }
    return resultArray;
}

System.Console.WriteLine();
int[,] resultArray = ProductArrays(quantityRow, quantityColumn);
// PrintArray(resultArray);
System.Console.WriteLine("Произведение этих двух матриц будет равно следующему массиву:");
PrintArray(resultArray);
