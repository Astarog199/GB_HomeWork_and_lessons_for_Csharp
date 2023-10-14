void MaxDigit(int num)
{
    int digit1 = num / 10;
    int digit2 = num % 10;
    if (digit1 > digit2)
        Console.WriteLine($"The biggest digit is {digit1}");
    else
        Console.WriteLine($"The biggest digit is {digit2}");
}

int number = new Random().Next(10, 100);
Console.WriteLine($"Your number is {number}");
MaxDigit(number);