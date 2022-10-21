// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Я очень долго мучилась и хоть убейте не пойму, почему мой код не работает... Надеюсь на ваш комментарий. Спасибо

System.Console.Write("Сколько чисел вы бы хотели ввести: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] InputNum()
{
    int length = quantity;
    int[] numbers = new int[length];
    for (int i = 1; i <= numbers.Length; i++)
    {
        System.Console.Write($"Введите число под номером {i}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

int[] num = InputNum();

int QuantityPositive()
{
    int count = 0;
    for (int i = 0; i <= quantity; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int result = QuantityPositive();
System.Console.WriteLine($"Количество введенных чисел больше нуля, равно: + {result}");



// И был у меня и такой вариант:
// System.Console.Write("Сколько чисел вы бы хотели ввести: ");
// int quantity = Convert.ToInt32(Console.ReadLine());

// int[] InputNumber()
// {
//     int length = quantity;
//     int[] numbers = new int[length];
//     for (int i = 1; i <= length; i++)
//     {
//         System.Console.Write($"Введите число под номером {i}: ");
//         numbers[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return numbers;
// }

// int[] num = InputNumber();

// int QuantityPositive(int number)
// {
//     int count = 0;
//     while (num[i] > 0)
//     {
//         count++;
//     }
//     return count;
// }

// int result = QuantityPositive(number);
// System.Console.WriteLine($"Количество введенных чисел больше нуля, равно: + {result}");
