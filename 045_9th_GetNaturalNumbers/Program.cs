// задать N, вывод натуральных чисел от 1 до N

int n = 7;

string GetNaturalNumbers(int N, int st = 0)
{
    if (st < N)
    {
        Console.Write(st + 1 + " ");
        st++;
        return GetNaturalNumbers(N, st);
    }
    else
    {
        return string.Empty;
    }

}

GetNaturalNumbers(n);

