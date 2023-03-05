// Напишите программу, которая задаёт массив из 8 элементов случайными числами 
// и выводит их на экран. Оформите заполнение массива и вывод в виде функции

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] InputArrey(int length)
{
    int[] R = new int[length];
    for (int i = 0; i < length; i++)
        R[i] = new Random().Next(10);
    return R;
}

int LengthArr = int.Parse(Console.ReadLine()!);
int[] arr = new int[LengthArr];
arr = InputArrey(LengthArr);
PrintArray(arr);
