/*
 Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/



int[,] Create2dArray(int min, int max, int NumberOfRows, int NumberOfColumns)
{
    int[,] array = new int[NumberOfRows, NumberOfColumns];
    for (int row = 0; row < NumberOfRows; row++)
    {
        for (int column = 0; column < NumberOfColumns; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine();
    for (int positionROW = 0; positionROW < array.GetLength(0); positionROW++)
    {
        for (int positionCOL = 0; positionCOL < array.GetLength(1); positionCOL++)
        {
            Console.Write($"{array[positionROW, positionCOL]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void calc(int[,] array, int GetInt)
{
    int NumberOfRows = array.GetLength(0); //получаем число строк
    int NumberOfColumns = array.GetLength(1); //получаем число столбцов
    int check = 0;


    for (int row = 0; row < NumberOfColumns; row++)
    {
        for (int column = 0; column < NumberOfRows; column++)
        {
            if (array[column, row] == GetInt)
            {
                Console.WriteLine($"The number in [{column + 1}, {row + 1}] is {GetInt}");
                check++;
            }
        }
    }
    if (check == 0) Console.Write($" There is no such index");

}

Console.Write($"Введите значение ");


int[,] array = Create2dArray(0, 9, 3, 3);
Show2dArray(array);
int GetInt = Convert.ToInt32(Console.ReadLine());
calc(array, GetInt);