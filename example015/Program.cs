int[] arr = { 1, 5, 8, 5, 3, 4, 6, 8, 2, 9 };
void printArray(int[] arr)
{
    foreach (int value in arr)
    {
        Console.Write($" {value}");
    }
    Console.WriteLine();
}
int[] SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }
        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;

    }
    return arr;
}

printArray(arr);
arr = SelectionSort(arr);
printArray(arr);
