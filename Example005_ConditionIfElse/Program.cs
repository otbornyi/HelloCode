Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
// Запрос на ввод имени пользователя , в случае если это Маша,
//  на экран выводится одно сообщение, во всех остальных другое.