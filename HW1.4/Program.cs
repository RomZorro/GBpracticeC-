﻿/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int big = 0;
if ((a > b) && (a > c))
{
    big = a;
}
else if ((b > a) && (b > c))
{
    big = b;
}
else if ((c > a) && (c > b))
{
    big = c;
}

Console.WriteLine("Максимальное число = " +big);
Console.WriteLine();
