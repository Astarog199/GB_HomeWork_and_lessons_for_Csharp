/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int number = 452;
int length = Length(number);

int Length(int number)
{
    int index = 0;
    while (number > 0)
    {
        number /= 10;
        index++;
    }
    return index;
}


int Sum(int number, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}



Console.Write($"Sum of digits in a number{number} is equal to {Sum(number, length)}");