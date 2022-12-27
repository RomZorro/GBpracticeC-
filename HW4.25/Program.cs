// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int num1 = ReadInt("Введите число A: ");
int num2 = ReadInt("Введите число B: ");
System.Console.WriteLine($"Решением задачи является число: {Power(num1, num2)}");


int Power(int a, int b)
{
    int pow = 1;
    for (int i = 1; i <= b; i++)
    {
        pow = pow * a;
    }
    return pow;
   //System.Console.WriteLine(pow);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
