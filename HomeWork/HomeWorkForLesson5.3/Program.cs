/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/




double[] FillArray(int max, int size)

{
    Random rand = new Random();
    double[] array = new double[size];

    for (int index = 0; index < size; index++)
    {
        array[index] = Math.Round(rand.NextDouble() * max, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    int size = array.Length;

    Console.Write($"Массив из {size} элементов -> [");

    for (int position = 0; position < size; position++)
    {
        Console.Write($"{array[position]} ");
    }

    Console.WriteLine("]");
}


double GetMin(double[] array)
{
    double res = array[0];

    for (int position = 0; position < array.Length; position++)
    {
        if (array[position] < res)
        {
            res = array[position];
        }
    }
    return res;
}

double GetMax(double[] array)
{

    double res = array[0];
    for (int position = 0; position < array.Length; position++)
    {
        if (array[position] > res)
        {
            res = array[position];
        }
    }

    return res;
}

void Calc(double minArray, double maxArray)
{
    double res = maxArray - minArray;
    Console.WriteLine($"Number of even numbers in the array -> {res}");
}




double[] array = FillArray(10, 10);
double minArray = GetMin(array);
double maxArray = GetMax(array);
PrintArray(array);

Console.WriteLine($"Minimum array element {minArray}");
Console.WriteLine($"Maximum array element {maxArray}");

Calc(minArray, maxArray);




