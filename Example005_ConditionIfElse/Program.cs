string userName;
Console.WriteLine("Введите имя пользователя: ");
userName = Console.ReadLine();

if (userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}
