// Задача 47. 

// Задайте двумерный массив размером m × n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine();
Console.Write("Введите количество строк: m =  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: n =  ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] CreateDoubleMatrixRnd(int m, int n)
{
    double[,] array = new double[m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 20 - 10;

        }
    }
    return array;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write(Math.Round(arr[i, j], 1) + "   ");
            else Console.Write("{0,8:F1}", Math.Round(arr[i, j], 1) + "|");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
double[,] res = CreateDoubleMatrixRnd(m, n);
PrintMatrix(res);

Console.WriteLine();
