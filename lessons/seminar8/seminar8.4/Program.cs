/*
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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



int[] getElements(int[,] matrix)
{
    int rowsCount = matrix.GetLength(0);
    int colsCount = matrix.GetLength(1);
    int size = rowsCount * colsCount;
    int index = 0;

    int[] container = new int[size]; // инициализация массива
    for (int row = 0; row < rowsCount; row++)
    {
        for (int column = 0; column < colsCount; column++)
        {
            container[index] = array[row, column];
            index++;
        }
    }
    return container;
}

int[] container = getElements(array);

void PrintArray(int[] array)
{
    int size = array.Length;

    Console.Write($"container -> [");

    for (int position = 0; position < size; position++)
    {
        Console.Write($"{array[position]} ");
    }
    Console.WriteLine("]");
}

PrintArray(container);



void arrayCheck(int[,] matrix, int[] container)
{
    int size = container.Length;

    int rowsCount = matrix.GetLength(0);
    int colsCount = matrix.GetLength(1);

    for (int row = 0; row < rowsCount; row++)
    {


        for (int column = 0; column < colsCount; column++)
        {

            int count = 0;
            for (int index = 0; index < size; index++)
            {
                if (array[row, column] == container[index])
                {
                    count++;
                }
            }
            Console.WriteLine($"элемент двумерного массива {array[row, column]} повторяется {count} раз");
        }
    }
}

arrayCheck(array, container);