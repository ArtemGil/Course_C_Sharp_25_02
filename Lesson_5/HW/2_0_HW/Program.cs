// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int SumNoChet(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, start, stop);

Print(mass);
Console.WriteLine($"Сумма не четных чисел: {SumNoChet(mass)}");

