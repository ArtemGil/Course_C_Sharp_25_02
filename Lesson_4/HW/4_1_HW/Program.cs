﻿// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int SumNum(int num){
    int sum = 0;
    for (int i = 0; num > 0; i++){
        sum = sum + num%10;
        num = num/10;
    }
    return sum;
}

int result = SumNum(int.Parse(Console.ReadLine()!));
Console.WriteLine(result);
