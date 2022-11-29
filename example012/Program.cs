//Четыре вида методов
// Принмают значения и не возвращают
// Не принимают значения и не возвращают
// Не принимают значния и возвращают
// Принимают значения и возвращают

void method1(string msg)
{
    Console.WriteLine(msg);
}

void method2()
{
    Console.WriteLine("Hello world!");
}
string method3()
{
    return "123";
}
string method4(string str)
{
    return str + "_123";
}
