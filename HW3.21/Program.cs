/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int[] point = new int[6];
Console.WriteLine("Введите x1 ");
point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1 ");
point[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1 ");
point[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2 ");
point[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2 ");
point[4] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2 ");
point[5] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Sqrt(Math.Pow(point[3] - point[0], y: 2)) + Math.Pow(point[4] - point[1], y: 2) + Math.Pow(point[5] - point[2], y: 2));
