/*
Задача 18: Напишите программу, которая по заданному номеру четверти, показывает
диапазон возможных координат точек в этой четверти (x и y).
*/


void Range( int quater){
    if (quater == 1) 
        Console.WriteLine("x>0 && y>0");
    else if(quater == 2) 
        Console.WriteLine("x<0 && y>0");
    else if(quater == 3) 
        Console.WriteLine("x<0 && y<0");
    else if (quater == 4) 
        Console.WriteLine("x>0 && y<0");
}

Console.WriteLine("Enternumber of quter: ");
int quater = Convert.ToInt32(Console.ReadLine());
if(quater<1 || quater>5){
    Console.WriteLine("Error");
}else
    Range(quater);