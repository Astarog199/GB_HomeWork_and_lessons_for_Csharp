/*
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты
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

int[,] calc(int[,] array)
{
    int NumberOfRows = array.GetLength(0); //получаем число строк
    int NumberOfColumns = array.GetLength(1); // получаем число столбцов

    int[,] newArray = new int[NumberOfRows, NumberOfColumns];
    for (int row = 0; row < NumberOfRows; row++)
    {
        for (int column = 0; column < NumberOfColumns; column++)
        {
            if (row % 2 == 0 && column % 2 == 0)
            {
                newArray[row, column] = array[row, column] * array[row, column];
            }
            else
            {
                newArray[row, column] = array[row, column];
            }

        }
    }
    return newArray;
}

int[,] array = Create2dArray(0, 9, 5, 5);
Show2dArray(array);
int[,] newArray = calc(array);
Show2dArray(newArray);