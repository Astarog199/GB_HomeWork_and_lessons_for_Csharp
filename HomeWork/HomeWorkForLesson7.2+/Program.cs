/*

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
с каждым новым элементом увеличивающимся на определенное число.
Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу. 
Элементы матрицы должны быть выведены через символ табуляции для более читаемого вывода.

Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. 
Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями:
значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - 
позиции элемента в матрице. Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), 
используя результаты из метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". 
Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".


n = 3;
m = 4;
k = 2;
x = 8;
y = 3;

1   3   5   7   
9   11  13  15  
17  19  21  23  

There is no such index

n = 4;
m = 5;
k = 3;
x = 2;
y = 2;



1   4   7   10  13  
16  19  22  25  28  
31  34  37  40  43  
46  49  52  55  58  

The number in [2, 2] is 37
*/


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


int n = 3;
int m = 4;
int k = 2;
int x = 8;
int y = 3;

// n = 4;
// m = 5;
// k = 3;
// x = 2;
// y = 2;

// Не удаляйте строки ниже
int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
int[] res2 = FindNumberByPosition(result, x, y);
PrintCheckIfError(res2, x, y);