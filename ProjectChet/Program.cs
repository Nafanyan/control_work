void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]} ");
    }
}

int[] RandomArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,101);
    }
    return array;
}

int[] RemoveZero (int[] sourceArray, int notZero)
{
    int[] resultArray = new int[notZero];
    for (int i = 0; i < notZero; i++)
    {
       resultArray[i] = sourceArray[i];
    }
    return resultArray;
}

int[] inputArray = new int[10];
int[] zeroInputArray = new int[inputArray.Length];
int count = 0;
inputArray = RandomArray(inputArray);
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

