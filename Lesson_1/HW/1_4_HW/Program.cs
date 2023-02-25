//Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int a = int.Parse(Console.ReadLine()!);
int number = 2;

while (number <= a)
{    
    if (number%2 == 0)
    {
    Console.Write(number + "; ");
    }
    number++;
}
