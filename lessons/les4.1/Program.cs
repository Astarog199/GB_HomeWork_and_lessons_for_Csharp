﻿
string[,] table = new string [2, 5];
// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

table[0, 0] ="Значение 0"; 
table[0, 1] ="Значение 1"; 
table[0, 2] ="Значение 2"; 
table[0, 3] ="Значение 3";
table[0, 4] ="Значение 4";

table[1, 0] ="Значение 5"; 
table[1, 1] ="Значение 6"; 
table[1, 2] ="Значение 7"; 
table[1, 3] ="Значение 8"; 
table[1, 4] ="Значение 9";


for (int rows=0; rows<3; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"{table[rows, columns]} ");
    }
    Console.WriteLine();
}