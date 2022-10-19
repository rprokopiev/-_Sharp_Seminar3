void FillRandArrayUserSet (int [] Array)
{ 
    int index = 0;
    Console.WriteLine("Введите максимально значение массива");
    int max = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение массива");
    int min = int.Parse(Console.ReadLine());
    while (index < Array.Length)
    {
        Array[index] = new Random().Next(min,max);
        index++;
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    int Lght = arr.Length;
    for(int i = 0; i<(Lght-1); i++)
    {
        Console.Write(arr[i]);
        Console.Write(",");
    }
    Console.Write(arr[Lght-1]);
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите длинну массива");
int Lght = int.Parse(Console.ReadLine());
int [] array = new int [Lght];
FillRandArrayUserSet(array);
PrintArray(array);

int i = 0;
int count = 0;
while(i<array.Length)
{
    if (i % 2 == 0)
    {
        i++;
    }
    else
    {
        count = count + array[i];
        i++;
    }
}
Console.WriteLine("сумма элементов, стоящих на нечётных позициях - " + count);