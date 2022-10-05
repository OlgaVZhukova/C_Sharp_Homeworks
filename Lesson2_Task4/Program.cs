// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число от 1 до 7 включительно:");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void Day (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        System.Console.WriteLine("Это выходной день.");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        System.Console.WriteLine("Вы ввели неверное число.");
    }
    else
    {
        System.Console.WriteLine("Это будний день.");
    }
}

Day (dayNumber);
