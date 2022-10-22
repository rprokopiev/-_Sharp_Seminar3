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

void DublicateArray(int [] array, int [] dublicate)
{
    int i = 0;
    while (i < array.Length)
    {
        dublicate[i] = array[i];
        i++;
    }
}

int Lght = GetNumber("Введите длинну массива");
int max = GetNumber("Введите максимальное значение массива");
int min = GetNumber("Введите минимальное значение массива");
int [] Array = new int [Lght];
FillArrayWithRandomNumbers(Array, max, min);
PrintArray(Array);

int [] DublArray = new int [Lght];
DublicateArray(Array, DublArray);
PrintArray(DublArray);