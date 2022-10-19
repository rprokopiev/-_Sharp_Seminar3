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
int Lght = int.Parse(Console.ReadLine());
int [] array = new int [Lght];
FillRandArrayUserSet(array);
PrintArray(array);
int m = 0;
int n = array.Length-1;

if (array.Length % 2 == 0) 
{
    int[] resultArray = new int [array.Length / 2];
    int i = 0;
    while (i<resultArray.Length)
    {
        resultArray[i] = array[n]*array[m];
        i++;
        n--;
        m++;
    }
    Console.WriteLine();
    Console.Write("Произведение пар: ");
    PrintArray(resultArray);
}
else
{
    int[] resultOddArray = new int [array.Length/2 + 1];
    int i = 0;
    while (i<resultOddArray.Length)
    {
        resultOddArray[i] = array[n]*array[m];
        i++;
        n--;
        m++;
        if (n==m) resultOddArray[i++] = array[n];
    }
    Console.WriteLine();
    Console.Write("Произведение пар: ");
    PrintArray(resultOddArray);
}
