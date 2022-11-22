int Max(int result, int arg2, int arg3)
{
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

Console.WriteLine(Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3)));
