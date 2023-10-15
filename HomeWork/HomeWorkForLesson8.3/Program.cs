/*
Умножения двух матриц

Аргументы, передаваемые в метод/функцию:

'1,2;3,4'
На выходе:


Исходная матрица:
1   2   
3   4   

Matrix B:
5   6   
7   8   

Multiplication result:
19  22  
43  50
*/

void PrintMatrix(int[,] matrix, string message) //Метод для вывода матрицы на консоль.
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
/*
 MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, 
возможно ли умножения двух матриц matrixA и matrixB. 
Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, 
то выводится сообщение "It is impossible to multiply."
 В противном случае, вызывается метод MatrixMultiplication для умножения матриц, 
и результат выводится с помощью метода PrintMatrix.
*/
void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{

    int ColumnsMatrixA = matrixA.GetLength(1); //получаем число столбцов
    int RowsMatrixB = matrixB.GetLength(0); //получаем число строк

    if (ColumnsMatrixA != RowsMatrixB)
    {
        Console.WriteLine("It is impossible to multiply.");
    }
    else
    {
        MatrixMultiplication(matrixA, matrixB);
    }
}

/*
MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц matrixA и matrixB. 
Метод возвращает новую матрицу, которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.

*/


int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{  // Введите свое решение ниже


    int RowsMatrix = matrixA.GetLength(0);
    int ColumnsMatrix = matrixA.GetLength(1); //получаем число столбцов

    int[,] res = new int[RowsMatrix, ColumnsMatrix];

    for (int row = 0; row < RowsMatrix; row++)
    {
        for (int column = 0; column < ColumnsMatrix; column++)
        {
            int result = 0;
            for (int inner = 0; inner < ColumnsMatrix; inner++)
            {
                result += matrixA[row, inner] * matrixB[inner, column];
            }
            res[row, column] = result;
        }
    }

    return res;
}






int[,] matrixA = new int[,] {
    {1, 2},
    {3, 4}
    };
PrintMatrix(matrixA, "Исходная матрица: matrixA");

Console.WriteLine();

int[,] matrixB = new int[,] {
    {5, 6},
    {7, 8}
    };


Console.WriteLine("\nMatrix B:");
PrintMatrix(matrixB, "Исходная матрица: matrixB");

Console.WriteLine("\nMultiplication result:");

MultiplyIfPossible(matrixA, matrixB);

int[,] res = MatrixMultiplication(matrixA, matrixB);

PrintMatrix(res, "res");