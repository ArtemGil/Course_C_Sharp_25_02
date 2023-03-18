// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

string convert(int num_1)
{
    string rezult = "";
    while (num_1 > 0)
    {
        rezult = num_1 % 2 + rezult;
        num_1 = num_1 / 2;
    }
    return rezult;
}

Console.WriteLine(convert(12));


