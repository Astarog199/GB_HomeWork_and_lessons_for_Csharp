
static void PrintArray(int[,] matrix)
{
    // Введите свое решение ниже
    for (int positionROW = 0; positionROW < matrix.GetLength(0); positionROW++)
    {
        for (int positionCOL = 0; positionCOL < matrix.GetLength(1); positionCOL++)
        {
            Console.Write($"{matrix[positionROW, positionCOL]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

static int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    // Введите свое решение ниже
    int[,] array = new int[n, m];

    int num = 1;
    for (int row = 0; row < n; row++)
    {
        for (int column = 0; column < m; column++)
        {
            array[row, column] = num;
            num += k;
        }
    }
    return array;
}

static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    // Введите свое решение ниже
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    int[] result = new int[1];

    if (rowPosition > rows || columnPosition > cols || rowPosition < 0 || columnPosition < 0)
    {
        result[0] = 0;
    }
    else
    {
        result[0] = matrix[rowPosition, columnPosition];
    }
    return result;
}

static void PrintCheckIfError(int[] results, int X, int Y)
{
    // Введите свое решение ниже
    if (results[0] == 0)
    {
        Console.WriteLine("There is no such index");
    }
    else
    {
        Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }
}


// Не удаляйте строки ниже
int[,] result = CreateIncreasingMatrix(3, 4, 2);
PrintArray(result);
int[] res2 = FindNumberByPosition(result, 8, 3);
PrintCheckIfError(res2, 2, 2);

