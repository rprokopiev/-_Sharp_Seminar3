int [] CreateRandomArray(int N, int min, int max)
{
    int [] array = new int [N];
    for (int i = 0; i<N; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}
int [] input = CreateRandomArray(12, -9, 9);

int positiveSum = 0;
int negativeSum = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] >0)
    {
        positiveSum += input [i];
    }
    else
    {
        negativeSum += input [i];
    }
}
string inputString = string.Join(",", input);
Console.WriteLine("Array = " + inputString + " Positive Sum = " + positiveSum + " Negative Sum = " + negativeSum);

