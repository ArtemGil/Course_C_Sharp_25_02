// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9

void SumPol(int b1, int k1, int b2, int k2)
{
    float x = (float) (b2 - b1) / (k1 - k2);
    float y = (float) k1 * x + b1;
    if (y == x)
        Console.WriteLine($"Пересечение в точки: {x}, {y}");
    else
        Console.WriteLine($"Пересечения нет!");
}

int b1_1 = int.Parse(Console.ReadLine()!);
int k1_1 = int.Parse(Console.ReadLine()!);
int b2_1 = int.Parse(Console.ReadLine()!);
int k2_1 = int.Parse(Console.ReadLine()!);
SumPol(b1_1, k1_1, b2_1, k2_1);
