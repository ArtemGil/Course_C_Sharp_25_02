// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (to - from) + from;
    }
    return arr;
}

double MaxMinDif(double[] arr)
{
    double dif = 0;
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
        if (arr[i] > max)
            max = arr[i];
    }
    dif = max - min;
    return dif;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
double[] mass = MassNums(num, start, stop);

Print(mass);
Console.WriteLine($"Разница max-min: {MaxMinDif(mass)}");
