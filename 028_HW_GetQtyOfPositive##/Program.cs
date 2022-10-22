int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
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

void FillArrayFromTerminal(int [] array)
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

int GetQtyOfPositiveNumbs (int [] array)
{
    int i = 0;
    int count = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
        {
            count++;
            i++;
        }
        else
        {
            i++;
        }
    }
    return count;
}

int Lght = GetNumber ("Введите кол-во чисел, которое хотите ввести");

if (Lght > 0)
{
    int [] Array = new int [Lght];
    FillArrayFromTerminal(Array);
    Console.Write("Введено ");
    PrintArray(Array);
    int result = GetQtyOfPositiveNumbs(Array);
    Console.WriteLine("Кол-во чисел больше 0 = " + result);
}
else
{
    Console.WriteLine("Ошибка ввода");
}
