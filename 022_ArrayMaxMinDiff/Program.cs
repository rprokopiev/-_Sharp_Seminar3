void FillRandArrayUserSet (double [] Array)
{ 
    int index = 0;
    Console.WriteLine("Введите максимально значение массива");
    int max = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение массива");
    int min = int.Parse(Console.ReadLine());
    while (index < Array.Length)
    {
        Array[index] = new Random().Next(min, max);
        index++;
    }
}

void PrintArray(double[] arr)
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
double [] array = new double [Lght];
FillRandArrayUserSet(array);
PrintArray(array);

double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
}

Console.WriteLine(min +" " + max);
Console.WriteLine(max - min);