Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int Z = num / 1000;
if(Z > 9 && Z < 100)
{
    int A = num % 10;
    int B = num / 10000;
    if(A == B)
    {
        int C = (num - (A * 10000)) / 10;
        int D = C % 10;
        int E = C / 100;
        if(D == E)
           {
              Console.Write(num);
              Console.WriteLine(" - Данное число является палиндромом");
           }
    }
    else
    {
        Console.WriteLine("Данное число паллидромом не является!!!");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число!!!");
}
