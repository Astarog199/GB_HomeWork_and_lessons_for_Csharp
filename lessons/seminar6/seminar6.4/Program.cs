/*
Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

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

int[] Fibonacci(int size)
{

    int[] array = new int[size];

    for (int index = 0; index < size; index++)
    {
        if (index == 0) array[0] = 0;
        else if (index == 1) array[1] = 1;
        else array[index] = array[index - 1] + array[index - 2];
    }
    return array;
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 0)
{
    Console.WriteLine("число должно быть положительным");

}
else
{
    int[] array = Fibonacci(number);
    PrintArray(array);
}
