/*
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
Поменять местами строки введеные пользователем
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

int[,] ChangeArray(int[,] array, int x, int y)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    x += -1;
    y += -1;

    int[,] newArray = new int[rows, cols];

    for (int positionROW = 0; positionROW < rows; positionROW++)
    {
        for (int positionCOL = 0; positionCOL < cols; positionCOL++)
        {
            if (positionROW == x)
                newArray[positionROW, positionCOL] = array[y, positionCOL];
            else if (positionROW == y)
                newArray[positionROW, positionCOL] = array[x, positionCOL];
            else
            {
                newArray[positionROW, positionCOL] = array[positionROW, positionCOL];
            }
        }

    }
    return newArray;
}



int[,] array = Create2dArray(0, 9, 4, 5);

Show2dArray(array);

int rows = array.GetLength(0);

int x = GetX(array);
int y = GetX(array);
Console.Write($"{x}:{y} ");



int GetX(int[,] array)
{
    Console.Write($"Веведите номер строки которую хотите перенести от 1 до {rows}: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num <= 0 || num > rows)
    {
        Console.WriteLine($"Ошибка ");

        GetX(array);
    }

    return num;


}



int[,] list = ChangeArray(array, x, y);
Show2dArray(list);