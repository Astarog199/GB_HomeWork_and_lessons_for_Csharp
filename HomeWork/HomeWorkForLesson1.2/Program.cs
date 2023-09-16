/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 
2, 3, 7 -> 7 
44 5 78 -> 78 
22 3 9 -> 22 
*/

int[] array = new int[3];
int length = 3;
int index = 0;
int i = 0;
int maxArray = 0;
while (index < length) 
{
    array[index] = new Random().Next(1, 100);
    index +=1;
}
// array[1] = 120;
while (i < length)
{
    if(array[i] > maxArray)
    {
        maxArray = array[i];
    }
    i++;
}
Console.Write(maxArray);
