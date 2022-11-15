int A = 2;
int B = 3;

int PowRecursion(int a, int b)
{
    if (b == 0) return 1;
    else return PowRecursion(a, b-1)*a;
}



Console.WriteLine(PowRecursion(A, B));


