int PrintReadIntReturn(string message)
{
    Console.WriteLine(message);
    int N = int.Parse(Console.ReadLine());
    return N;
}
int EntryLenght(int Entry)
{
    int i = 0;
    while (Entry > 0)
    {
        Entry = Entry / 10;
        i++;
    }
    return i;
}
void ArrayPrint(int[] ar)
{
    int i = 0;
    int l = ar.Length;
    while (i<l)
    {
        Console.Write(ar[i]);
        Console.Write(" / ");
        i++;
    }
}

int Number = PrintReadIntReturn("Введите 5ти значной число");
int Lght = EntryLenght(Number);
int [] array = new int [Lght];
int index = 0;
if(Lght != 5) Console.WriteLine("Ошибка ввода");
else
{
    while (Number > 0)
    {
        int N = Number % 10;
        array [index] = N;
        Number = Number/10;
        index++;        
    }
}
if (array[0]==array[4] && array[1]==array[3])
{
    Console.WriteLine("палиндромом");
}
else
{
    Console.WriteLine("не палиндромом");
}
