// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

System.Console.WriteLine("Введите число:");
string number = Console.ReadLine();
if (number.Length > 2)
{
  System.Console.WriteLine("Третья цифра - " + number[2]);
}
else {
  System.Console.WriteLine("Третьей цифры нет");
}
