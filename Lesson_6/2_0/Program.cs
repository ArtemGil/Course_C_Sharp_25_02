// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.

void Trngl(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine("Yes, It's true!");
    else
        Console.WriteLine("No, It's false :( ");
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);

Trngl(num1, num2, num3);
