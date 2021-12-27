void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]} ");
    }
}

int[] RemoveZero (int[] sourceArray, int notZero)
{
    int[] resultArray = new int[notZero];
    for (int i = 0; i < notZero; i++)
    {
        if (sourceArray[i] != 0)
        {
            resultArray[i] = sourceArray[i];
        }
    }
    return resultArray;
}

int[] inputArray = {1, 2, 4, 12, 7, 34, 0, 6};
int[] zeroInputArray = new int[inputArray.Length];
int count = 0;
PrintArray(inputArray);
Console.Write(" => ");
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i] % 2 == 0)
    {
        zeroInputArray[count] = inputArray[i];
        count++;
    }
}
PrintArray(RemoveZero(zeroInputArray, count));

