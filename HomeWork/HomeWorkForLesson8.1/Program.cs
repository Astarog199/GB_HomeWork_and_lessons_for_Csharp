/*
Сортировка строк матрицы по убыванию

Инструкция по использованию платформы


Напишите программу для работы с матрицей целых чисел.

Реализуйте класс MatrixOperations, который содержит следующие статические методы:

PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. 
Он принимает на вход двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.

SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так, чтобы элементы в каждой строке шли по убыванию.


matrix = new int[,] {
    {5, 2, 9},
    {8, 1, 4},
    {6, 7, 3}
    };

На выходе:

Исходная матрица:
9   1   7   
1   2   3   
4   5   6   

Матрица с упорядоченными по убыванию строками:
9   7   1   
3   2   1   
6   5   4

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

void Show2dArray(int[,] matrix, string message)
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



int[,] SortRowsDescending(int[,] matrix)
{
    int NumberOfRows = matrix.GetLength(0); //получаем число строк
    int NumberOfColumns = matrix.GetLength(1); //получаем число столбцов
    int SizeCol = matrix.Length / NumberOfRows;

    int num;


    for (int positionROW = 0; positionROW < NumberOfRows; positionROW++)
    {

        num = 0;
        for (int positionCOL = 0; positionCOL < NumberOfColumns; positionCOL++)
        {
            int temp;


            for (int index = 0; index < SizeCol; index++)
            {
                if (matrix[positionROW, num] > matrix[positionROW, index])
                {
                    temp = matrix[positionROW, index];
                    matrix[positionROW, index] = matrix[positionROW, num];
                    matrix[positionROW, num] = temp;
                }
            }
            num++;
        }
    }

    return matrix;
}

// int[,] matrix = new int[,] {
//     {5, 2, 9},
//     {8, 1, 4},
//     {6, 7, 3}
//     };

int[,] matrix = new int[,] {
    {9, 1, 7},
    {1, 2, 3},
    {4, 5, 6}
    };


// int[,] array = Create2dArray(matrix, 5, 5);
Show2dArray(matrix, "Исходная матрица: ");
SortRowsDescending(matrix);
Show2dArray(matrix, "Матрица с упорядоченными по убыванию строками: ");
