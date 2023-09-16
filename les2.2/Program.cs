int [] array = new {10, 24, 44, 33};
int n = array.Length;
int i = 0;
int max = 0;

while (i < n)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    i++;  
}
 Console.Write(max);
