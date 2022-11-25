int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);

int Involution(int a, int b)
{
    int count = 1;
    for (int i = 0; i < b; i++)
    {   
        count *= a;
    }
    return count;
}
void Print(int arg)
{
    Console.WriteLine(arg);
}

Console.WriteLine($"{a} and {b}");
Print(Involution(a, b));

