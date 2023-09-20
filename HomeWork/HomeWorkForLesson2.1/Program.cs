/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
*/

int i = new Random().Next(100, 999);

void Mama_i_am_a_criminal(int i)
{
    Console.Write($"Second character of the number {i}: ");
    char[] arr = i.ToString().ToCharArray();
    Console.WriteLine(arr[1]);
}



void GoodBoy(int i)
{
    int res = (i / 10) - (i / 100 * 10);
    Console.WriteLine($"Second character of the number {res}");
}

Mama_i_am_a_criminal(i);
GoodBoy(i);
