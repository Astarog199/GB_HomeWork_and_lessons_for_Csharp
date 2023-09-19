void CutNumber(int num = 0)
{
    if (num < 100 || num > 999)
    {
        Console.WriteLine("Error");
    }
    else
    {
        int digit1 = num / 100 * 10;
        int digit3 = num % 10;

        int new_num = digit1 + digit3;
        Console.WriteLine($"New num is {new_num}");
    }
}

int num = new Random().Next(10, 1000);
Console.WriteLine($"Your number is {num}");
CutNumber(num);