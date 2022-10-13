// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int A = InputNumber("Введите первое число: ");
int B = InputNumber("Введите второе число: ");

int DegreeResult(int number)
{
	int degree = A;
	for (int i = 1; i <= B - 1; i++)
	{
		degree = degree * A;
	}
    if (B == 0)
    {
        int result_DegreeZero = 1;
        System.Console.WriteLine($"Результат возведения первого числа в нулевую степень числа равен: {result_DegreeZero}");
    }
	return degree;
}
	
int result = DegreeResult(A);
System.Console.WriteLine($"Результат возведения первого числа в степень второго числа равен: {result}");
