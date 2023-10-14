// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

bool Check(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
        return true;
    else
        return false;
}

Console.WriteLine($"Your number ");
int num = Convert.ToInt32(Console.ReadLine());
bool flag = Check(num);
if (flag)
    Console.WriteLine("True");
else
    Console.WriteLine("False!");