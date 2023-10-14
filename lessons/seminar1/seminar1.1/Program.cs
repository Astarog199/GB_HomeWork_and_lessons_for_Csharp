//принмаем трёх значное число и на выходе показываем последнюю цифру этого числа

int i = new Random().Next(100, 999);
//int i = -345;
Console.Write($"last character of the number {i}: ");
char[] arr = i.ToString().ToCharArray();

int position = arr.Length;
Console.WriteLine(arr[position - 1]);
