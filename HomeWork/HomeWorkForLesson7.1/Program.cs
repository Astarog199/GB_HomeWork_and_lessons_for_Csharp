// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Create2dArray(int min, int max, int NumberOfRows, int NumberOfColumns)
{
    Random rand = new Random();
    double[,] array = new double[NumberOfRows, NumberOfColumns];
    for (int row = 0; row < NumberOfRows; row++)
    {
        for (int column = 0; column < NumberOfColumns; column++)
        {
            array[row, column] = Math.Round(rand.NextDouble() * (max - min) + min, 2);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
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

double[,] array = Create2dArray(-9, 9, 4, 3);
Show2dArray(array);