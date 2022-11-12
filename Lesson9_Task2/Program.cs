﻿// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");

int SumMN(int m, int n)
{
    int result = m;
    if (m == n || m > n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}

void SumFromMToN(int m, int n)
{
    Console.Write($"Cумма чисел от M до N равняется {SumMN(m - 1, n)} ");
}

SumFromMToN(m, n);

