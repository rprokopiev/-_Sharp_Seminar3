int GetEntry (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FillArrayWithFibonacci(int [] array)
{
    array[0] = 0;
    array[1] = 1;
    int i = 2;
    while (i < array.Length)
    {
        array[i] = array[i-2] + array[i-1];
        i++;
    }
}

void ArrayPrint(int [] array)
{
    Console.Write("[");
    int i = 0;
    while(i < array.Length-1)
    {
        Console.Write(array[i] + ", ");
        i++;
    }
    Console.Write(array[array.Length-1] + "]");
}

int X = GetEntry("Введите требуемое кол-во чисел Фибоначи");
int [] FibArray = new int[X];
FillArrayWithFibonacci(FibArray);
ArrayPrint(FibArray);