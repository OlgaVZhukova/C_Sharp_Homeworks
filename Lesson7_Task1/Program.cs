// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int lenRows, int lenColumns)
{
    double[,] array = new double[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble() * 10;
        }
    }
    return array;
}

//выведем теперь это на экран
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t"); //благодаря \t (табуляции) будут более-менее ровные колонки, даже с 2-х-значными числами
        }
        System.Console.WriteLine(); // отображение простой строчки после каждой строчки
    }
}

//теперь нужно массив сгенерировать
double[,] array = CreateArray(3, 4);
PrintArray(array);


