/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
/* второе решение
Console.WriteLine("Введите число");
string s = Console.ReadLine();
int n = Convert.ToInt32(s);
Console.WriteLine(n % 2 == 0 ? "Четное" : "Не четное");
*/

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 1)
{
    Console.WriteLine("Число " + a + " является нечётным ");
}
else
{
    Console.WriteLine("Число " + a + " является чётным ");
}



