// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
int quantityColumn = Prompt("Введите такое же количество столбцов матрицы: ");
int[,] array = CreateArray(quantityRow, quantityColumn);
int[,] secondArray = CreateArray(quantityRow, quantityColumn);
PrintArray(array);
System.Console.WriteLine();
PrintArray(secondArray);

int[,] ProductArrays(int quantityRow, int quantityColumn)
{
    int[,] resultArray = new int[quantityRow, quantityColumn];
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
System.Console.WriteLine("Произведение этих двух матриц будет равно следующему массиву:");
PrintArray(resultArray);



/*На самом деле:
Алгоритм умножения матриц

Умножаем элементы в строках первой матрицы на элементы в столбцах второй матрицы.

1. Умножаем элементы первой строки на элементы первого столбца.
- Умножаем первый элемент первой строки на первый элемент первого столбца.
- Умножаем второй элемент первой строки на второй элемент первого столбца.
- Делаем то же самое с каждым элементом, пока не дойдем до конца как первой строки первой матрицы, так и первого столбца второй матрицы.
- Складываем полученные произведения.
- Полученный результат будет первым элементом первой строки произведения матриц.
2. Умножаем элементы первой строки первой матрицы на элементы второго столбца второй матрицы.
- Умножаем первый элемент первой строки на первый элемент второго столбца.
- Умножаем второй элемент первой строки на второй элемент второго столбца.
- Делаем то же самое с каждым элементом, пока не дойдем до конца как первой строки первой матрицы, так и второго столбца второй матрицы.
- Складываем полученные произведения.
- Полученный результат будет вторым элементом первой строки произведения матриц.
3. Применяя тот же самый алгоритм, умножаем элементы первой строки первой матрицы на элементы остальных столбцов второй матрицы. Полученные числа составят первую строку вычисляемой матрицы.
4. Вторая строка вычисляемой матрицы находится аналогично умножением элементов второй строки первой матрицы на элементы каждого столбца второй матрицы: результаты записываются в новую матрицу после каждого суммирования.
5. Делаем это с каждой строкой первой матрицы, пока все строки новой матрицы не будут заполнены.*/
