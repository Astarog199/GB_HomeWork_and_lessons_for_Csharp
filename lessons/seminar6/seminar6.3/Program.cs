/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/



// Получаем длину
int getLength(int res)
{

    int length = 0;
    for (int count = 0; res > 0; count++)
    {
        res /= 2;
        length++;
    }
    return length;
}


// решение
int[] Calc(int res, int size)
{
    int[] array = new int[size];
    for (int position = size - 1; position >= 0; position--)
    {
        array[position] = res % 2;
        res /= 2;
    }
    return array;
}

// Вывод массива
void PrintArray(int[] array, int res)
{
    int size = array.Length;

    Console.Write($"Десятичное число {res} в двоичное -> ");

    for (int position = 0; position < size; position++)
    {
        Console.Write($"{array[position]}");
    }
}


int res = 375;
int size = getLength(res);
int[] array = Calc(res, size);
PrintArray(array, res);