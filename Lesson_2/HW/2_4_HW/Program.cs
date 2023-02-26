// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Week(int num)
{
    if (num < 1 || num > 7)
        Console.WriteLine("Не верный ввод! Введите число от 1 до 7.");
    else
    {    
        if (num < 6)
            Console.WriteLine("Нет, это будний день.");
        else 
            Console.WriteLine("Да, это выходной день!!!");
    }
}
Week(int.Parse(Console.ReadLine()!));
