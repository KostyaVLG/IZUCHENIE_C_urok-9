// Задача 2: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
Console.WriteLine($"Вот список натуральных чисел в заданном диапазоне");
PrintInterval(n, 1);
Console.WriteLine();
Console.WriteLine($"Сумма чисел в диапазоне от 1 до {n} будет равна [{CalculateSumm(n, 1)}]");

int CalculateSumm(int m, int n)
{
int start = m;
int end = n;
if(m > n)
{
start = n;
end = m;
}
return (end + start)*(end - start + 1)/2;
}

Console.WriteLine();
