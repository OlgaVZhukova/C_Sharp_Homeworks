// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Мое решение:
// int InputNumber(string msg)
// {
//     System.Console.WriteLine(msg);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int A = InputNumber("Введите первое число: ");
// int B = InputNumber("Введите второе число: ");

// int DegreeResult(int number)
// {
// 	int degree = A;
// 	for (int i = 1; i <= B - 1; i++)
// 	{
// 		degree = degree * A;
// 	}
// 	return degree;
// }

// int result = DegreeResult(A);
// if (B == 0)
//     {
//         System.Console.WriteLine("Результат возведения числа в нулевую степень равен: 1");
//     }
// else
// {
//     System.Console.WriteLine($"Результат возведения первого числа в степень второго числа равен: {result}");;
// }

// Решение с семинара:

System.Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());

if (B >= 0)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    System.Console.WriteLine($"Число {A} в степени {B} равно {result}");
}
else
{
    System.Console.WriteLine($"Число {B} не натуральное");
}
