// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите номер строки заданного элемента в массиве: ");
int i1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца заданного элемента в массиве: ");
int j1 = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + "   ");
            else Console.Write(arr[i, j] + "|");
        }
        Console.WriteLine();
    }
}

void SearchNumber(int[,] arr)
{
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == i1 && j == j1)
            {
                res = arr[i, j];
                Console.WriteLine($"Заданный элемент: {res} ");
                break;
            }
        }
    }
    if (res == 0) Console.WriteLine("такого элемента нет ");
}

int[,] matrix = CreateMatrixRndInt(m, n, min, max);
Console.WriteLine();

PrintMatrix(matrix);
Console.WriteLine();

SearchNumber(matrix);
