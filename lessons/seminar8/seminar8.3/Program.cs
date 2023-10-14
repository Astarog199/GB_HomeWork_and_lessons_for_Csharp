/*
Заменяем строки на столбцы, а строки на столбцы в массиве.
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

void Show2dArray(int[,] matrix, string message = "")
{
    Console.WriteLine();

    Console.WriteLine(message);
    int rowsCount = matrix.GetLength(0);
    int colsCount = matrix.GetLength(1);
    Console.Write("\t");
    for (int j = 0; j < colsCount; j++)
    {
        Console.Write($"col{j}\t");
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < rowsCount; i++)
    {
        Console.Write($"row{i}:\t");
        for (int j = 0; j < colsCount; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = Create2dArray(0, 9, 3, 3);
Show2dArray(array, "Отображаем созданный массив");


int[,] change2dArr(int[,] array)
{

    int Rows = array.GetLength(0); //получаем число строк
    int Columns = array.GetLength(1); // получаем число столбцов

    if (Rows != Columns)
    {
        Console.WriteLine("ошибка: Количество строк и столбцов должно быть одинаковым");
        return array;
    }

    int column2 = 0;
    int row2;

    int[,] array2 = new int[Rows, Columns];

    for (int row = 0; row < Rows; row++)
    {
        row2 = 0;
        for (int column = 0; column < Columns; column++)
        {
            array2[row2, column2] = array[row, column];
            row2++;
        }
        column2++;
    }
    return array2;
}


int[,] newArr = change2dArr(array);
Show2dArray(newArr, "Меняем местами строки и столбцы в массиве");
