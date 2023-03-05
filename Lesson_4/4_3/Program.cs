//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

void Massiv(int leght)
{
    int[] R = new int[leght];
    for (int i=0; i<leght; i++)
    {
        R[i] = new Random().Next(2);
        Console.WriteLine();
        Console.WriteLine(R[i]);
    }
}

Massiv(int.Parse(Console.ReadLine()!));
