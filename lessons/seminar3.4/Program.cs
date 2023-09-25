/*
Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

void myFunc(int N) {
int num =1;

Console.Write($"{N} ->");

for (int i =1; i <= N; i++)
{
    Console.Write($" {num * num},");
    num++;  
}
}

Console.WriteLine("Enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N<0) N = N * (-1);
if(N == 0) Console.WriteLine(" Err");

myFunc(N);
