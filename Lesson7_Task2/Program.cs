// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 0,2 -> 7

System.Console.Write("Введите номер позиции элемента в строке: ");
int indexRow = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер позиции элемента в колонке: ");
int indexColumn = Convert.ToInt32(Console.ReadLine());

//я умею и функцией, но мне хотелось различить приглашение на ввод указанием именно на то строка это или колонка.
// int Prompt()
// {
//     System.Console.WriteLine("Введите число:");
//     int a = Convert.ToInt32(Console.ReadLine());
//     return a;
// }
// int indexRow = Prompt();
// int indexColumn = Prompt();

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 10);
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

int Search(int[,] array, int indexRow, int indexColumn)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[indexRow, indexColumn])
            {
                return array[i, j];
            }
        }
    }
    return -1;
}

int[,] array = CreateArray(3, 4);
PrintArray(array);
int result = Search(array, indexRow, indexColumn);
System.Console.WriteLine();
System.Console.WriteLine($"Значение искомого элемента: {result}");

// if (indexRow > array.GetUpperBound(0))
// {
//     System.Console.WriteLine("Таких позиций в массиве нет.");
// }
// else
// {
//     System.Console.WriteLine($"Значение искомого элемента: {result}");
// }

// bool ValidateSearch(int[,] array, int indexRow, int indexColumn)
// {
// 	if (indexRow < 0 || indexRow > array.Length)
// 	{
// 		Console.WriteLine("Такой позиции в массиве нет.");
// 		return false;
// 	}

// 	if (indexColumn < 0 || indexColumn > array.Length);
//     {
// 		Console.WriteLine("Такой позиции в массиве нет.");
// 		return false;
// 	}
// 	return indexRow;
// }

// if (ValidateSearch(array, indexRow, indexColumn))
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == array[indexRow, indexColumn])
//             {
//                 return array[i, j];
//             }
//         }
//     }
//     System.Console.WriteLine($"Значение искомого элемента: ");
// }
