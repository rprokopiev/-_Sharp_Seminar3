// вход - число, выход - сумма цифр числа

int number = 11111;

int GetDigitSum(int number, int sum = 0)
{
    {
        if (number > 0 && number / 10 == 0)
        {
            sum += number;
            return sum;
        }
        else
        {
            sum += number % 10;
            number /= 10;
            return GetDigitSum(number, sum);
        }

    }
}

Console.WriteLine(GetDigitSum(number));

// int i = 100;
// i /= 10;
// Console.Write(i);
