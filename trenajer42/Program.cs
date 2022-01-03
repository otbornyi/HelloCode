int count = 7;
int A = 0;
for(int i = 0; i < count; i++)
{
    Console.Write("Введите число ");
    int username = int.Parse(Console.ReadLine());
    if(username > 0)
    {
        A = A + 1;
    }
}
Console.WriteLine($"Количество введеных пользователем положительных цифр - {A}");


