Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower()=="асгард")
{
Console.WriteLine("Ура, это же красотулечка!!!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}