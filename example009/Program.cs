int[] array = { 12, 21, 43, 12, 44, 22, 90, 21, 445, 65, 12, 43 };
int max = 0;
foreach (int element in array)
{
    if (max < element) max = element;
}
Console.WriteLine(max);