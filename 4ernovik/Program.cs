Console.WriteLine("Введите числа : ");
string a = Console.ReadLine();
int length = a.Length;
int b = 0;
int count = 0;

for (int i = 0; i < a.Length; i++)
{
    b = Convert.ToInt32(a[i]);
    Console.WriteLine(b);
    if(b > 0)
    {
        count++;
    }
}
Console.WriteLine($"Введено чисел больше ноля {count}");