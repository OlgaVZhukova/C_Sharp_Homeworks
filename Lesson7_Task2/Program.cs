// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 0,2 -> 7

int indexRow = Prompt("Введите номер позиции элемента в строке от 0 до 2: ");
int indexColumn = Prompt("Введите номер позиции элемента в колонке 0 до 3: ");
int[,] array = new int[3, 4];
CreateArray(array);
PrintArray(array);

if (indexRow < array.GetLength(0) || indexColumn < array.GetLength(1)) Console.WriteLine($"Значение искомого элемента: {array[indexRow, indexColumn]}");
else Console.WriteLine($"{indexRow},{indexColumn} -> такого числа в массиве нет.");

void CreateArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
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

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


