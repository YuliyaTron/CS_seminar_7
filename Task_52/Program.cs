// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


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

void SearchArithmMeanElementColumn(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double res = 0;
        int count = 0;
        double sumElementColumn = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sumElementColumn = sumElementColumn + arr[i, j];
            count++;
        }
        res = sumElementColumn / count;

        //Console.Write($"{Math.Round(res, 1)}  ");
        Console.Write("{0:N1}  ", res);
    }
}

int[,] matrix = CreateMatrixRndInt(m, n, min, max);
Console.WriteLine();

PrintMatrix(matrix);
Console.WriteLine();

SearchArithmMeanElementColumn(matrix);
Console.WriteLine();

