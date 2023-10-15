/*
Определение строки с наименьшей суммой элементов

Инструкция по использованию платформы



Напишите программу для работы с матрицей целых чисел.

Реализуйте класс Answer, который содержит следующие статические методы:

Аргументы, передаваемые в метод/функцию:

'9, 1, 7; 1, 2, 3; 4, 5, 6'
На выходе:


Исходная матрица:
9   1   7   
1   2   3   
4   5   6   

Сумма наименьшей строки (строка 2): 6
*/

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

// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix. 
// Метод принимает двумерный массив целых чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.
int SumOfRow(int[,] matrix, int row)
{
    int rowsCount = matrix.GetLength(0);
    int colsCount = matrix.GetLength(1);
    int res = 0;
    for (int col = 0; col < colsCount; col++)
    {
        res += matrix[row, col];
    }
    return res;

}

//      MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. 
//      Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: 
//      номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.
int[] MinimumSumRow(int[,] matrix)
{
    int rowsCount = matrix.GetLength(0);
    int colsCount = matrix.GetLength(1);

    int[] array = new int[rowsCount];
    int[] result = new int[2];
    int minEL;
    int minRow;

    for (int row = 0; row < rowsCount; row++)
    {
        int res = 0;
        for (int column = 0; column < colsCount; column++)
        {
            res += matrix[row, column];

        }

        array[row] = res;
    }
    minEL = array[0];
    minRow = 0;
    for (int index = 0; index < rowsCount; index++)
    {
        if (minEL > array[index])
        {
            minEL = array[index];
            minRow = index;
        }
    }
    result[0] = minRow;
    result[1] = minEL;

    return result;
}


int[,] matrix = new int[,] {
    {5, 2, 9},
    {8, 1, 4},
    {6, 7, 3}
    };

int[,] matrix2 = new int[,] {
    {9, 1, 7},
    {1, 2, 3},
    {4, 5, 6}
    };



Show2dArray(matrix, "Исходная матрица: ");

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма указанной строки {row}: {SumOfRow(matrix, row)}");


int[] minSumRow = MinimumSumRow(matrix);

Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

// Console.WriteLine($"Результат: {res}");