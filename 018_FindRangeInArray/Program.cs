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

int [] array = new int [123];
FillRandArrayUserSet(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>=10 && array[i]<=99)
    {
        count = count + 1;
        i++;
    }
}
Console.WriteLine(count);