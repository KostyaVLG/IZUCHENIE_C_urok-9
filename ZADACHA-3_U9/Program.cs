
// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m от 2 до 3: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n от 3 до 2: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<2 || n>3)
{
    Console.WriteLine("Не допустимые значения !!! Повторте попытку");
    return;
}

if (m<2 || m>3)
{
    Console.WriteLine("Не допустимые значения !!! Повторте попытку");
    return;
}

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
