int a = 8;
int b = 12;
int c = 1;
int d = 3;
int e = 92;
int f = 10;

int max = a;

if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;
if (max < f) max = f;

Console.WriteLine(max);