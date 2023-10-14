// Упорядочить массив


int[] array = { 6, 8, 3, 2, 1, 4, 5, 7 };

void PrintArray(int[] array)
{
    int length = array.Length;
    int max = 0;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine(" ");
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j; // дз: поменять символ "<" на ">"
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);