int M = 1;
int N = 11;

string GetNaturalBetween(int M, int N)
{
    if (M < N-1) 
    {
        M++; 
        Console.Write(M + " ");
        return GetNaturalBetween(M, N);
    }
    else
    {
        return string.Empty;
    }
}

GetNaturalBetween(M, N);

