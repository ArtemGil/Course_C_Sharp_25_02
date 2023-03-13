// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь

void SumPol(int num)
{
    int sum = 0;
    int a;
    for (int i = 0; i < num; i++)
    {
        a = int.Parse(Console.ReadLine()!);
        if (a > 0)
            sum++;
    }
    Console.WriteLine($"Сумма положительных чисел: {sum}");
}

Console.WriteLine("Сколько чисел хочешь ввести? ");
int n = int.Parse(Console.ReadLine()!);
SumPol(n);
