// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.


void Palindrome(int num)
{
    int a1 = num/10000;
    int a2 = (num/1000)%10;
    int a4 = (num%100)/10;
    int a5 = num%10;
    if (a1 == a5 && a2 == a4)
       Console.WriteLine("Yes, It's Palindrome!");
    else
       Console.WriteLine("No, It is'n Palindrome.");
}

int num = int.Parse(Console.ReadLine()!);
Palindrome(num);
