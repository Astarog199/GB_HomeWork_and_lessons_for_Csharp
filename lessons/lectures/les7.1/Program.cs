


int[] FillArray(int size)
{
    int[] array = new int[size]; // инициализация массива
    int num = size;
    for (int index = 0; index < size; index++)
    {
        array[index] = num--;
    }
    return array;
}

void PrintArray(int[] array, string text)
{
    int size = array.Length;

    Console.Write($"{text} -> [");

    for (int position = 0; position < size; position++)
    {
        Console.Write($"{array[position]} ");
    }
    Console.WriteLine("]");
}



int[] loop(int[] t1)
{
    int size = t1.Length;
    int[] t2 = new int[size];
    int[] t3 = new int[size];
    int cell;

    for (int position = 0; position < size; position++)
    {
        if (t2[position] == 0 && position != (size - 1))
        {
            cell = t1[position];
            t1[position] = t2[position];
            t2[position] = cell;
        }
        else if (position == (size - 1))
        {
            cell = t1[0];
            t3[0] = t1[position];
            t1[position] = t1[0];
        }

    }

    int index = 1;
    size = t1.Length;

    for (int position = size - 2; position >= 0; position--)
    {
        cell = t3[index];
        t3[index] = t2[position];
        t2[position] = cell;

        index++;

    }

    PrintArray(t1, "t1+");
    Console.WriteLine("----------");
    PrintArray(t2, "t2");
    Console.WriteLine("----------");
    PrintArray(t3, "t3");
    return t3;
}



int[] t1 = FillArray(7);
PrintArray(t1, "t1");
loop(t1);
