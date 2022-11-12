// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

void EvenFromMToN(int m, int n)
{
    if (m > n)
    {
        return;
    }

    if (m % 2 == 0)
    {
        System.Console.Write(m + " ");
        EvenFromMToN(m + 2, n);
    }
    else
    {
        System.Console.Write("");
        EvenFromMToN(m + 1, n);
    }
}

int m = Prompt("Введите число M");
int n = Prompt("Введите число N");
EvenFromMToN(m, n);


