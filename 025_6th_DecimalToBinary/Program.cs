int Prompt (string message)
{
    Console.WriteLine(message);
    int A = int.Parse(Console.ReadLine());
    return A;
}

int DigitQtyInBinar (int number)
{
    int Lght = 0;
    int var = number;
    while (var>0)
    {
        var = var / 2;
        Lght++;
    }
    return Lght;
}

void GetArrayOfBinaryDigits (int [] binArr, int number)
{
    int var2 = number;
    for (int i = binArr.Length - 1; i > -1; i--)
    {
        binArr[i] = var2 - ((var2 / 2)*2);
        var2 = var2 / 2;
    }
}

void WriteArray (int [] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i]);
        i++;
    }
}

int N = Prompt("Введите положительное число");

int Lght = DigitQtyInBinar(N);

int [] list = new int [Lght];
GetArrayOfBinaryDigits (list, N);
WriteArray(list);

string correct = Convert.ToString(-25,2);
Console.WriteLine();
Console.WriteLine(correct);

