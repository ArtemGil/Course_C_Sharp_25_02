// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

string FindIndex(int[,] array, int A, int B)
{
    if (A <= array.GetLength(0) && B <= array.GetLength(1))
        return $"Значение индекса {A},{B}: {array[A - 1, B - 1]}";
    else
        return "Нет таких индексов";
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);

Console.WriteLine("Введите индекс нужного элемента: ");
int indexA = int.Parse(Console.ReadLine()!);
int indexB = int.Parse(Console.ReadLine()!);
string Itog = FindIndex(mass, indexA, indexB);
Console.WriteLine($" {Itog}");
