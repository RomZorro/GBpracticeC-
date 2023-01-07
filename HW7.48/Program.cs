// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();
System.Console.WriteLine("Введите размер массив M x N");
int m = inputNumber("М = ");
int n = inputNumber("N = ");
double[,] array = new double[m, n]; 
FillArrayRandomNumbers(array);
PrintArray(array);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-999, 999) / 10.0;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int inputNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// double inputNumber(string str)
// {
//     double number;
//     string text;

//     while (true)
//     {
//         System.Console.Write(str);
//         text = Console.ReadLine();
//         if (double.TryParse(text, out number))
//         {
//             break;
//         }
//         System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
//     }
//     return number;
// }