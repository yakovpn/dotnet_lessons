void FillArray(int[] collection)
{
    for (int key = 0; key < collection.Length; ++key) collection[key] = new Random().Next(1, 10);
}
void PrintArray(int[] col)
{
    foreach (var element in col)
    {
        Console.WriteLine(element);
    }
}
int[] values = new int[20];
 int IndexOf(int[] values, int searchValue) {
    for (int key = 0; key < values.Length; ++key)
    if (searchValue == values[key])
    {
        return key;
    }
    return -1;
}
FillArray(values);
PrintArray(values);
Console.WriteLine();
Console.WriteLine(IndexOf(values,4));
