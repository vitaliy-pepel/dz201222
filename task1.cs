//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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

Console.Clear();
System.Console.WriteLine("Введите размер массива");
int m = InputNumber("Введите значение m: ");
int n = InputNumber("Введите значение n: ");
double[,] arr = FillAndPrintArray(m,n);


double[,] FillAndPrintArray(int m, int n)
{
double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10, 10) + new Random().NextDouble();
            System.Console.Write(Math.Round(array[i,j], 2) + " ");
        }
        System.Console.WriteLine();
    }
    return array;
}
