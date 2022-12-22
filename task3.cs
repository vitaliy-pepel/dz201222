// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int InputNumber(string str)
{
int number;
string text;
    while (true)
    {
    Console.Write(str);
    text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
        break;
    }
    Console.WriteLine("Введено не число, попробуйте еще раз.");
    }
    return number;
}

int[,] FillAndPrintArray(int m, int n)
{
int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(10, 99);
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    return array;
}

Console.Clear();
System.Console.WriteLine("Введите размер массива");
int m = InputNumber("Введите значение m: ");
int n = InputNumber("Введите значение n: ");
int[,] arr = FillAndPrintArray(m,n);
SrZnach();

void SrZnach()
{
    for (int j = 0; j < n; j++)
    {
        int s = 0;
        for (int i = 0; i < m; i++)
        {
            s += arr[i, j];
        }
        System.Console.Write($"{ Math.Round((double) s / (double) m, 1)}; ");
    }
}
