// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] NewArray(int[] arr)
{
    int[] arrnew;
    
    if (arr.Length % 2 == 1)
    {
        arrnew = new int[arr.Length / 2 + 1];
        arrnew[arr.Length / 2] = arr[arr.Length / 2];
    }
    else
        arrnew = new int[arr.Length / 2];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        arrnew[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return arrnew;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Console.Write("Исход массив: ");
Print(mass);

int[] array = NewArray(mass);
Console.Write("Новый массив: ");
Print(array);
