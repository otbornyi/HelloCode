int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;
int Today = new Random().Next(1, 8);
Console.WriteLine(Today);
if(Today == Monday)
{
Console.WriteLine("Сегодня Понедельник");
}
if(Today == Tuesday)
{
Console.WriteLine("Сегодня Вторник");
}
if(Today == Wednesday)
{
Console.WriteLine("Сегодня Среда");
}
if(Today == Thursday)
{
Console.WriteLine("Сегодня Четверг");
}
if(Today == Friday)
{
Console.WriteLine("Сегодня Пятница");
}
if(Today == Saturday)
{
Console.WriteLine("Сегодня Суббота");
}
if(Today == Sunday)
{
Console.WriteLine("Сегодня Воскресенье");
}