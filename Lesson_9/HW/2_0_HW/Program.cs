// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120; M = 4; N = 8 -> 30.

int ValuesSet(int M, int N, int ConstM)
{
    if (N < ConstM) return 0;
    return ValuesSet(M + 1, N - 1, ConstM) + M;
}

int numM = int.Parse(Console.ReadLine()!);
int numN = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValuesSet(numM, numN, numM));
