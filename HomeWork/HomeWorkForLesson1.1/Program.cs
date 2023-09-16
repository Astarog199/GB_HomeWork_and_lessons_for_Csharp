/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
a = 5; b = 7 -> max = 7 
a = 2 b = 10 -> max = 10 
a = -9 b = -3 -> max = -3 
*/

int a = new Random().Next(1, 10); 
int b = new Random().Next(1, 10);
Console.Write("Число a = ");
Console.Write(a);
Console.Write(", число b = ");
Console.WriteLine(b);

int max = 0;
if (a>b)
{
    max = a;
}else{
max =b;
}
Console.Write("max = ");
Console.WriteLine(max);
