// Факториал числа n

int Fact(int n)
{
    if (n > 1)
    {
        return Fact(n - 1) * n;
    }
    else
    {
        return 1;
    }
}

int res = Fact(5);
Console.Write(res);

/*
n=5;
(5-1) * 5 = 20;
(4-1) * 20 = 60; 
(3-1) * 60 = 120;
(2-1) * 120 = 120;
(1>1) => false;
Fact = 120;

Fact(1) => false;
Fact(2) * 120 = 120;
Fact(3) * 60 = 120;
Fact(4) * 20 = 60;
Fact(5) * 5 = 20;
*/