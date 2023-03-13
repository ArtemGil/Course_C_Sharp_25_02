// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования. 

void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{string.Format("{0:F2}",arr[i])}  ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
        arr[i] = rnd.NextDouble() * (to - from) + from;
    return arr;
}

double[] MassCopy(double[] arr, double[] arrnew)
{
    for (int i = 0; i < arr.Length; i++)
        arrnew[i] = arr[i];
    return arrnew;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
double[] mass = MassNums(num, start, stop);
double[] massnew = new double[num];

MassCopy(mass, massnew);
Print(mass);
Console.WriteLine("Новый массив:");
Print(massnew);
