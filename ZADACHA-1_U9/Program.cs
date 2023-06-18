﻿// Задача 1: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число больше еденицы: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintInterval(int m, int n)
{
int start = m;
int end = n;
if(m > n)
{
start = n;
end = m;
}
for(int i = start; i <= end; i++)
{
Console.Write($"{i} ");
}
}
Console.WriteLine($"Вот список натуральных чисел в заданном вами диапазоне");
PrintInterval(n, 1);
		
Console.WriteLine();