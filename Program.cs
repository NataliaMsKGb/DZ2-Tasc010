﻿
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решить без использования строк.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите целое трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());

int b=a/10;
int c=b%10;

Console.WriteLine ($"{c}");
