//Напишите программу, которая принимает
//на вход три числа и выдаёт максимальное из этих

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

if (a > b && a > c)
{
    Console.Write("Max = "+a);    
}

if (b > a && b > c)
{
    Console.Write("Max = "+b);    
}

if (c > a && c > b)
{
    Console.Write("Max = "+c);    
}
