// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральну степень B.

double Degree(int num, int stepen)
{
    double result = Math.Pow(num, stepen);
    return result;
}

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Degree(A, B));
