/*
Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое
каждого столбца: 4,6; 5,6; 3,6; 3.

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


void calc(int[,] array)
{
    int NumberOfRows = array.GetLength(0); //получаем число строк
    int NumberOfColumns = array.GetLength(1); //получаем число столбцов

    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int row = 0; row < NumberOfColumns; row++)
    {
        double res = 0;
        for (int column = 0; column < NumberOfRows; column++)
        {
            res += array[column, row];
        }
        double result = Math.Round(res / NumberOfRows, 2);

        Console.Write($"{result}; ");
    }
}

int[,] array = Create2dArray(0, 9, 3, 5);
Show2dArray(array);
calc(array);