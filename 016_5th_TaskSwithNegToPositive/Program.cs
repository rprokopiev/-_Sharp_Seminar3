void SwitchArrayPositNegative(int [] array)
{
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] < 0)
        {
            array[i] = array [i] + (2 * array [i]);
            i++;
        }
        else
        {
            array[i] = array[i] - (2 * array[i]);
            i++;
        }
    }
}

int [] test = {1,2,3,4,5};
SwitchArrayPositNegative(test);
// int i = 0;
// while(i < test.Length)
// {
//     Console.Write(test[i] + " / ");
//     i++;
// }

