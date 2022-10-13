// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8


int [] array = new int[8];
Random myRandom = new Random();
 
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 100);
    Console.Write(array[i] + " ");
}
