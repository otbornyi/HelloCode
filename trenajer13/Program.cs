int A = new Random().Next(100, 1000);
Console.WriteLine(A);
if(A % 3 == 0)
{
    if(A % 23 == 0)
    {
        int B = A / 3;
        Console.Write(A);
        Console.WriteLine(" - кратен 3 и 23");
    }
    else
    {
    Console.WriteLine("Не кратен ни одному, или одному из элементов 3 и 23. ");
    }
}
else
    {
    Console.WriteLine("Не кратен ни одному, или одному из элементов 3 и 23. ");
    }
