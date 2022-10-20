﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Графики двух линейных функций параллельны друг другу, если имеют одинаковый угловой коэффициент (k) и различное значение b (если и b будет одно и то же, то это будет одна и та же функция).
// Пример: графики функций y = 2x – 3 и y = 2x + 1 параллельны и, следовательно, не пересекаются.

// Если две линейные функции имеют различные k, но одинаковые b, то они пересекаются в точке (0; b).

// точка пересечения — это та точка, где у обоих функций одинаковы x и y.
// Если y одинаковы, то правая часть одного уравнения равна правой части другой. То есть их можно приравнять и найти значение x, при котором это равенство верно.
// А далее, имея x, можно вычислить y, через любую из функций. Пример:
// Даны y = 4x – 5 и y = –2x + 1
// 4x – 5 = –2x + 1
// 4x + 2x = 1 + 5
// 6x = 6
// x = 1
// y = 4 * 1 – 5 = –1 или y = –2 * 1 + 1 = –1
// Таким образом точка пересечения (1; –1).

double InputNumber(string msg)
{
	System.Console.WriteLine(msg);
	double number = Convert.ToInt32(Console.ReadLine());
	return number;
}

double k1 = InputNumber("Введите первый угловой коэффициент k1:");
double b1 = InputNumber("Введите первый свободный член b1:");
double k2 = InputNumber("Введите второй угловой коэффициент k2:");
double b2 = InputNumber("Введите второй свободный член b2:");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны друг другу.");
}

if (b1 == b2)
{
    Console.WriteLine($"Прямые пересекаются в точке (0; {b1}).");
}

double x = (b2 - b1) / (k1 - k2);
double y = k1*x + b1;
System.Console.WriteLine($"Точка пересечения двух прямых находится в точке с координатами: ({x};{y})");

