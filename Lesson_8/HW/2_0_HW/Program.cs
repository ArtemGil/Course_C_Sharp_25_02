﻿// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
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

void MinLine(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min = 0;
    int RowMin = 0;

    for (int j = 0; j < column; j++)
        for (int i = 0; i < row; i++)
        {
            min = min + arr[i, j];
            RowMin = i;
        }

    Console.Write("Строка минимум: ");
    for (int j = 0; j < column; j++)
        Console.Write($" {arr[RowMin, j]} ");
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
MinLine(mass);
