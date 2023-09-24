/*
Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.

Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:
AB = √(xb - xa)2 + (yb - ya)2

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Enter coordinates of Ax: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinates of Ay: ");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates of Bx: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinates of By: ");
int By = Convert.ToInt32(Console.ReadLine());

double GettingDistance(int Ax, int Ay, int Bx, int By){
   double AB = Math.Round(Math.Sqrt(((Bx-Ax) *(Bx-Ax)) + ((By -Ay)* (By -Ay))),2);
   return AB;
}

Console.WriteLine($"Distance: {GettingDistance(Ax, Ay, Bx, By)}");

