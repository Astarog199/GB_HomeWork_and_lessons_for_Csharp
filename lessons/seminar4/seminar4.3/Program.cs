// Находит все нечётные числа от 1 до N

Console.WriteLine($"Введите число.");
int number = Convert.ToInt32(Console.ReadLine());

void func(int number)
{
    for (int i = 1; number >= i; i++)
    {
        if (i % 2 == 1)
            Console.WriteLine($"{i} нечётное число.");
        else
            Console.WriteLine($"{i} чётное число.");
    }
}

func(number);
