int[] FillArray()
{
    int[] array = new int[16];
    for (int i = 0; i < 16; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
    Console.Write("]");
}
PrintArray(FillArray());