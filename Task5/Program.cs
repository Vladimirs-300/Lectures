Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "вова")
{
    System.Console.WriteLine("Приветству, Владимир!!!");
}
else
{
System.Console.WriteLine("Привет, ");
System.Console.WriteLine(username);
}