// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

void Third(int num)
{
    if (num < 100)
        Console.WriteLine("Третьей цифры НЕТ!");
    else
    {
        while (num > 999)
            num = num / 10;
        Console.WriteLine("3я цифра = " + num % 10);
    }
}
Third(int.Parse(Console.ReadLine()!));
