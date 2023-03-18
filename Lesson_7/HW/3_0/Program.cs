//Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void MiddleColumn(int[,] array)
{
    double N;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        N = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            N = N + array[j, i];
        N = N / array.GetLength(1);
        Console.Write($"{string.Format("{0:F1}", N)} ");
    }
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
MiddleColumn(mass);
