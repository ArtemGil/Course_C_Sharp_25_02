// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int SumNum(int num)
{
    int length = 1;
    int temporary = num;
    while (temporary > 0)
    {
        temporary = temporary / 10;
        length = length * 10;
    }
    length = length / 10;
    int sum = 0;

    while (length > 1)
    {
        sum = sum + (num/length);
        num = num - ()
        length--;

    }
    return length;
}

int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);
