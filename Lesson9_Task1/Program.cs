// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");
int count = 0;

int EvenFromMToN(int m, int n, int count)
{
    if (m > n)
    {
        System.Console.Write("M больше N, не получится подсчитать. ");
        // return 0;
    }
    else
    {
        // EvenFromMToN(m, n);
        if (m % 2 != 0) return EvenFromMToN(m + 1, n, count);
        // {
        //     count = count + 2;
        //     Console.Write(count + " ");
        // }
        else return EvenFromMToN(m + 2, n, count);
        // {
        //     count++;
        //     Console.Write(count + " ");
        // }
        // return;
    }
    return 0;
}

EvenFromMToN(m, n, count);
