/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
if (num > 999)
{
System.Console.WriteLine("Число не трехзначное");
}
else
{
string chr = Convert.ToString(num);
System.Console.WriteLine($"{chr[1]}");
}
