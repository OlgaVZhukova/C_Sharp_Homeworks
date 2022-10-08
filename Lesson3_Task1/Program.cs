// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int n = InputNumber("Введите пятизначное, либо другое число: ");
int temporary = n;
int reverse = 0;

while (n > 0)
{
    int result = n % 10;
    reverse = (reverse * 10 + result);
    n = n / 10;
}

if (temporary == reverse)
{
    System.Console.WriteLine("Данное число является палиндромом.");
}
else
{
    System.Console.WriteLine("Данное число не являтеся палиндромом.");
}
