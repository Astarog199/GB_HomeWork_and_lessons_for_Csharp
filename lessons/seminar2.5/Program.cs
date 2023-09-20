// Напишите программу, которая принимает на
// вход два числа и выводит, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток

void Check(int num1, int num2)
{
    if (num2 % num1 == 0)
        Console.WriteLine("True");
    else
        Console.WriteLine($"false {num2 % num1}");
}

Console.WriteLine($"Your number 1");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == 0)
    Console.WriteLine("Error");
else
    Check(num1, num2);