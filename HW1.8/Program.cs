﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
/*
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine);
count = 0;

while (count < a)
*/
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.Write($"{i} ");