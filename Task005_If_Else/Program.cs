Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "maksim")
{
    Console.WriteLine("Привет, дорогой!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}