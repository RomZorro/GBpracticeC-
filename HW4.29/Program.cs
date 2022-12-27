// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
System.Console.WriteLine("Введите размер массива");
int arrLength = inputNumber();
int[] arr = Auto(arrLength);
System.Console.WriteLine(string.Join(" | ", arr));

int[] Auto(int len)
{
    int[] arr = new int[len];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10, 10);
    }
    return arr;
}
int inputNumber()
{
    int number;
    string text;
    while (true)
    {
        Console.WriteLine(value: "Введите число");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine(value: "Не удалось распознать число, поробуйте ввести число заново");
    }
    return number;
}