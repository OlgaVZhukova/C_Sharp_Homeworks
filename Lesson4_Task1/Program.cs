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

// int degree = 0;
// for (int B = 0; B <= A; i++)
// {
//     degree = degree * i;
// }

int Degree(int number)
{
    int x = A;
    int y = B;
    
}




int Degree(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

System.Console.WriteLine(A);
System.Console.WriteLine(B);



