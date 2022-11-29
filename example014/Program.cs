string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    for (int i = 0; i < text.Length; i++)
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    return result;
}