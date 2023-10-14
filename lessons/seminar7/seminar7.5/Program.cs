/*
1. Вывести на экран матрицу 4х6. 
2. Найти сумму каждой строки.
3. Вывести результат в виде одномерного массива.
4. Найте его максимальный элемент.
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

void PrintArray(int[] array)
{
    int size = array.Length;

    Console.Write($"Массив из {size} элементов -> [");

    for (int position = 0; position < size; position++)
    {
        Console.Write($"{array[position]} ");
    }

    Console.WriteLine("]");
}

int[] calc(int[,] array)
{
    int NumberOfRows = array.GetLength(0); //получаем число строк
    int NumberOfColumns = array.GetLength(1); //получаем число столбцов

    int[] newArray = new int[NumberOfRows];

    for (int row = 0; row < NumberOfRows; row++)
    {
        for (int column = 0; column < NumberOfColumns; column++)
        {
            newArray[row] += array[row, column];

        }
    }
    return newArray;
}


void GetMaxArray(int[] newArray)
{

    int maxArray = 0;

    for (int position = 0; position < newArray.Length; position++)
    {
        if (newArray[position] > maxArray)
        {
            maxArray = newArray[position];
        }
    }

    Console.WriteLine($"Максимальный элемент: {maxArray}");
}


int[,] array = Create2dArray(0, 9, 4, 6);
Show2dArray(array);
int[] newArray = calc(array);
PrintArray(newArray);
GetMaxArray(newArray);