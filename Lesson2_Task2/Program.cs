﻿// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(99, 1000);
System.Console.WriteLine(a);
int num1 = a % 10;
int num2 = a / 100; 
System.Console.WriteLine($"{num2}{num1}");