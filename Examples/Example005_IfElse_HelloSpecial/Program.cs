Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, Машенька, привет!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}