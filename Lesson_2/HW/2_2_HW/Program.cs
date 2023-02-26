// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

int TakeNum(int num)
{
    Console.WriteLine(num);
    int sum = ((num / 100) * 10) + (num % 10);
    return sum;
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);
