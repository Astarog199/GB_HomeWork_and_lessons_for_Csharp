/*
17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

int Quat(int x, int y){
    if(x > 0 && y>0)
        return 1;
    else if(x<0 && y>0)
        return 2;
    else if(x>0 && y<0)
    return 4;
    else 
        return 3;
}

Console.WriteLine("Enter x point: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y point: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x!=0 && y!=0){
    int quater = Quat(x, y);
    Console.WriteLine($"The number of quter is {quater}");
}else {
    Console.WriteLine($"The number of quter is quater");
}


