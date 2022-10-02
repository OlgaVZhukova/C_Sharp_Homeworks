// Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.
// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < n; i++)
{
    if(i % 2 == 0)
    {
        System.Console.WriteLine(i);
    }
}

