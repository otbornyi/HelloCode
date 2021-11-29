int A = new Random().Next(1, 100);
Console.WriteLine(A);
if(A > 999)
{
    int B = (A % 100);
    int D = (B - (A % 10)) / 10;
    Console.WriteLine(D);
}
else
{
    if((A / 10) > 9)
    {
    int C = A % 10;
    Console.WriteLine(C);
    }
       else
       {
           Console.WriteLine("Третьей цифры в числе нету");
       }
}       