// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральну степень B.

int Degree(int num, int stepen)
{
    int sum = 1;
    for (int i = 0; i < stepen; i++)
    {
        sum = sum * num;
    }
    return sum;
}

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Degree(A, B));
