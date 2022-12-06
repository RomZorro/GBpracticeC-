/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
Console.WriteLine("Какой сейчас день недели? ");
int a == (Понедельник);
int b == (Вторник);
int c == (Среда);
int d == (Четверг);
int e == (Пятница);
int f == (Суббота);
int g == (Воскресенье);

if ("int a == 1; int b == 2; int c == 3; int d == 4; int e == 5")

{
  Console.WriteLine(("Будние дни"));  
}
if ("int f == 6; int g == 7")
{
  Console.WriteLine(("Выходные"));  
}
else
{
  Console.WriteLine("Не является днем недели");  
} */

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Понедельник - Будний день"); break;
    case 2: Console.WriteLine("Вторник - Будний день"); break;
    case 3: Console.WriteLine("Среда - Будний день"); break;
    case 4: Console.WriteLine("Четверг - Будний день"); break;
    case 5: Console.WriteLine("Пятница - Будний день"); break;
    case 6: Console.WriteLine("Суббота - Выходной"); break;
    case 7: Console.WriteLine("Воскресенье - Выходной"); break;
    default: Console.WriteLine("Не является днем недели"); break;
}
Console.ReadKey();

