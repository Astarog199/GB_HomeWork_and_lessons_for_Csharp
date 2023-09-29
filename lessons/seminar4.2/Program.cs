/*
Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int number = 5;

void func(int number)
{
    int res = 1;
    for (int i = 1; i <= number; i++)
    {
        res *= i;
    }

    Console.WriteLine($"product of {number} from 1 is {res}.");
}
func(number);