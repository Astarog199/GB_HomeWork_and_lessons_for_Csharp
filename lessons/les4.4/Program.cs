// Программа вычисляет факториал числа
double Factorial (int n)
{
    // 1! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}

for (int i =1; i<=20; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
// 19! = 1,21645100408832E+17 (число у множенное на 10(17) десять в семнадцатой степени)