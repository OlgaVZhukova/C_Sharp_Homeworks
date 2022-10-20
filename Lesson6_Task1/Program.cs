// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Сколько чисел вы бы хотели ввести: ");
int quantity = Convert.ToInt32(Console.ReadLine());

// int InputNumber(string message)
// {
//     Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     for (int i = 1; i < length; i++)
//     {
        
//     }
//     return number;
// }

// int n = InputNumber("Введите число:");

int[] Numbers(int[] array)
{
    int length = quantity;
    int[] arr = new int[length];
    for (int i = 1; i <= arr.Length; i++)
    {
        System.Console.Write($"Введите число под номером {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int[] numbers = Numbers(arr);

int QuantityPositive()
{
    int count = 0;
    for (int i = 0; i < quantity; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < quantity; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

PrintArray(QuantityPositive(array));

int count = QuantityPositive();
// System.Console.WriteLine(numbers);
System.Console.WriteLine("Количество введенных чисел больше нуля, равно: " + count);

// void Prompt(string[] msg)
// {
// //     System.Console.Write("Введите количество чисел, которые хотите ввести:\t");
//     // int quantity = Convert.ToInt32(Console.ReadLine());
//     int[] myArray = new int[quantity];
//     for (int i = 1; i <= myArray.Length; i++)
//     {
//         System.Console.WriteLine($"Введите число под номером {i}:");
//         myArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     System.Console.WriteLine("Вывод массива:");
// //     for (int j = 0; j < myArray.Length; j++)
//     {
//         System.Console.WriteLine(myArray[j]);
//     }
//     return myArray;    //Console.WriteLine(); // Console.ReadLine();
// }

// int array = Prompt(myArray);

// int[] Array(string[] args)
// {
//     int[] arr = new int[10];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     System.Console.WriteLine(arr[4]);
//     Console.ReadLine();
//     return arr;
// }

// int[] arr = Array(arr);


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}\t");
//     }
//     System.Console.WriteLine();
// }

// int Count(int[] array)
// {
// 	int count = 0;
// 	for (int i = 0; i <= array.Length; i++)
// 	{
// 		if(array[i] > 0)
// 		{
// 			count++;
// 		{
// 	}
// 	return count;
// }

// PrintArray(array);
// Prompt("Введите число:");
// int result = Count(array);
// System.Console.WriteLine(result); //($"Количество введенных чисел больше нуля, равно: {result}")

