// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string message)
{
	System.Console.WriteLine(message);
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

int Count(int number)
{
	int result = 0;
	while (number > 0)
	{
		number = number / 10;
		result++;
	}
	return result;
}

int number = InputNumber("Введите число: ");
int result = Count(number);

int SumNumbers(int number)
// {
// 	int sum = 0;
// 	for (int i = 1; i <= result; i++)
// 	{
// 		sum += number % 10;
// 		number = number / 10;
// 	}
// 	return sum;
// }
{
	int result = 0;
    while (number > 0)
    {
        result+=number%10;
        number = number / 10;
    }
    return result;
}


int sum = SumNumbers(number);
System.Console.WriteLine($"Сумма цифр числа равна: {sum}");
