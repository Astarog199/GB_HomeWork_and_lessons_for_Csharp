/*
Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/




// Создание массива и заполнение его

int[] FillArray(int min, int max, int size)

{
    int[] array = new int[size];

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(min, max + 1);
    }
    return array;
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


void Calc(int[] array)
{

    int sumPos = 0;
    int sumNeg = 0;

    for (int position = 0; position < array.Length; position++)
    {
        if (array[position] < 1)
        {
            sumPos += array[position];
        }
        else
        {
            sumNeg += array[position];
        }

    }
    Console.Write($"{sumPos} ");
    Console.Write($"{sumNeg} ");

}


int[] array = FillArray(-9, 9, 12);
PrintArray(array);
Calc(array);