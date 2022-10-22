// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] InputNum(int quantity)
{
    int length = quantity;
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"Введите число под номером {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

int QuantityPositive(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.Write("Сколько чисел вы бы хотели ввести: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] num = InputNum(quantity);


int result = QuantityPositive(num);
System.Console.WriteLine($"Количество введенных чисел больше нуля, равно: + {result}");
