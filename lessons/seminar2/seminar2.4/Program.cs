// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.

bool AIsSqureOfb(int num1, int num2)
{
    if (num1 == num2 * num2 || num2 == num1 * num1)
        return true;
    else
        return false;
}

Console.WriteLine("input first numb:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second numb:");
int num2 = Convert.ToInt32(Console.ReadLine());

bool isSqure = AIsSqureOfb(num1, num2);
Console.WriteLine(isSqure);