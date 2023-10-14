/*
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

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

int[,] ChangeArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    int row = 0;
    int col = 0;

    int[,] result = new int[rows, cols];

    for (int positionROW = rows - 1; positionROW >= 0; positionROW--)
    {
        for (int positionCOL = cols - 1; positionCOL >= 0; positionCOL--)
        {
            result[row, col] = array[positionROW, positionCOL];
            col++;
        }
        row++;
        col = 0;
    }
    return result;
}

int[,] array = Create2dArray(0, 9, 4, 4);
Show2dArray(array);
int[,] list = ChangeArray(array);
Show2dArray(list);