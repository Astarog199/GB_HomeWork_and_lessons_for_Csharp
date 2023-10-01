/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int A = 2;
int B = 4;

void func(int A, int B)
{
    double res = A;
    for (int i = 1; i < B; i++)
    {
        res *= A;
    }
    Console.WriteLine($"{A} to the power of {B} is equal to {res}");
}
Console.WriteLine($"enter the number A");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"enter the number B");
B = Convert.ToInt32(Console.ReadLine());

func(A, B);