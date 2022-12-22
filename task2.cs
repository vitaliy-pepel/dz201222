// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

System.Console.WriteLine("Поиск элемента массива по индексу:");
int x = InputNumber("Введите значение i: ");
int y = InputNumber("Введите значение j: ");
Search(x, y);

void Search(int x, int y)
{
    if ((x < m && y < n) && (x >= 0 && y >= 0)) 
    {
        System.Console.WriteLine(arr[x,y]);
    }
    else 
    {
        System.Console.WriteLine("такого числа в массиве нет");
    }
}