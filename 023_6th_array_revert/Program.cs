void FillRandArrayUserSet (double [] Array)
{ 
    Console.WriteLine("Введите длинну массива");
    int Lght = int.Parse(Console.ReadLine());
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


