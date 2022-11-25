int Number = new Random().Next(1, 10000);

//Узнаем размер числа
int size = Number.ToString().Length;

int GetNumbers(int Number)
{
    int rem = 0;
    int sum = 0;
     for (int i = 0; i < size; i++)
     {
        rem = Number % 10;
        Number = (Number / 10);
        sum = sum + rem;
     }
     return sum;
 }
 Console.WriteLine(Number);
 Console.WriteLine(GetNumbers(Number));