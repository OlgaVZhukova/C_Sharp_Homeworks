// Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.
// Пример:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число, пожалуйста: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число, пожалуйста: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число, пожалуйста: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    if(number1 > number3)
    {
        System.Console.WriteLine($"Число {number1} является максимальным из этих чисел.");
    }
    else
    {
        System.Console.WriteLine($"Число {number3} является максимальным из этих чисел.");
    }
}
else
{
    if(number2 > number3)
    {
        System.Console.WriteLine($"Число {number2} является максимальным из этих чисел.");
    }
    else
    {
        System.Console.WriteLine($"Число {number3} является максимальным из этих чисел.");
    }
}
