// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

string GetNumber(int number)
{
    Console.Write(number + ", ");
    if (number == 2) 
    {
        Console.Write(number-1); 
        return string.Empty;
    }
    else return GetNumber(number-1);
}

int N = 9;
GetNumber(N);
