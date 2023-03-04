// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.


void Squares(int num)
{
    int i = 1;
    Console.Write($"{num} -> ");

    while (num >= i)
    {
        Console.Write($"{Math.Pow(i, 2)}, ");
        i++;
    }
    Console.WriteLine();
}

int num = int.Parse(Console.ReadLine()!);
Squares(num);
