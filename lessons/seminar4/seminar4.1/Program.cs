/*
Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int num = 89126;
int number = num;
void func(int num, int number)
{
    int num2 = 0;
    while (num > 1)
    {
        num = num / 10;
        num2++;
    }
    Console.WriteLine($"the number of digits in a {number} is {num2}.");
}
func(num, number);