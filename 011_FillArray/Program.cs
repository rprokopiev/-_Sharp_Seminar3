void FillArray(int [] array)
{
    int i = 0;
    int Lght = array.Length;
    while (i < Lght)
    {
        array[i] = new Random().Next(0,2);
        i++;
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

int [] Array = new int [8];
FillArray(Array);
PrintArray(Array);
