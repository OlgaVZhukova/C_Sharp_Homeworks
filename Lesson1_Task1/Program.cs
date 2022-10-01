// Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а 
// какое меньшее.
// Пример:
// a = 5; b = 7 -> max = 7, 
// min = 5
// a = -9 b = -3 -> max = -3, 
// min = -9

System.Console.WriteLine("Введите первое число, пожалуйста: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число, пожалуйста: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    System.Console.WriteLine($"Число {number1} является большим, а число {number2} - меньшим.");
}
else
{
    System.Console.WriteLine($"Число {number2} является большим, а число {number1} - меньшим.");
}
