/*
Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
Для остальных чисел вернуть True или False.

14212 -> False
12821 -> True
234322 -> Число не пятизначное
                     False
*/

int num = 14212;

void IsPalindrome(int num)
{
    int num1, num2, num3, num4, num5;

    num1 = num / 10000 * 10000;
    num2 = num / 1000 * 1000 - num1;
    num3 = num / 100 * 100 - num2 - num1;
    num4 = num / 10 * 10 - num3 - num2 - num1;
    num5 = num - num4 - num3 - num2 - num1;

    int result = (num5 * 10000) + (num4 * 100) + (num3) + (num2 / 100) + (num1 / 10000);


    if (num < 10000 || num > 99999)
    {
        Console.WriteLine("Число не пятизначное");
        Console.Write(false);
    }
    else if (num == result)
    {
        Console.Write(true);
    }
    else
    {
        Console.Write(false);
    }
}

IsPalindrome(num);

