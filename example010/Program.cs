int[] values = { 12, 21, 43, 12, 44, 22, 90, 21, 445, 65, 12, 43 };
int search = 445;

for (int key = 0; key < values.Length; ++key)
    if (search == values[key])
    {
        Console.WriteLine(key);
    }
    