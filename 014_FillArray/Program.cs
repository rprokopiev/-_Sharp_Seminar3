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
}

Console.WriteLine("Введите длинну массива");
int Lgth = int.Parse(Console.ReadLine());
int [] Array = new int [Lgth];
FillRandArrayUserSet(Array);
PrintArray(Array);