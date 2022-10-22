int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FillArrayWithRandomNumbers(int [] array, int max, int min)
{
    int i = 0;
    while (i<array.Length)
    {
        array[i] = new Random().Next(min, max);
        i++;
    }
}

void PrintArray (int [] array)
{
    Console.Write("[");
    int i = 0;
    while (i < array.Length-1)
    {
        Console.Write(array[i] + ", ");
        i++;
    }
    Console.WriteLine(array[array.Length-1] + "]");
}

void FillIntArrayFromTerminal(int [] array)
{
    int i = 0;
    int count = 1;
    array[i] = GetNumber("Введите первое число");
    i++;
    count++;
    while (i<array.Length-1)
    {
        array[i] = GetNumber("Введите следующее число, номер " + count);
        i++;
        count++;
    }
    array[array.Length-1] = GetNumber("Введите последнее число");
}
