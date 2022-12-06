/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
string chr = Convert.ToString(num);

if (chr.Length >= 3)
{
    System.Console.WriteLine($"{chr[2]}");
}
else
{
    System.Console.WriteLine("Число не содержит третьего знака");
}
