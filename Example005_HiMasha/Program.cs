Console.WriteLine("Введите имя пользователя: ");
String username = Console.ReadLine();

if(username.ToLower() == "ксюша")
{
    Console.WriteLine("Ура, это же КСЮША!");
}
else
{
    Console.Write("Приет, ");
    Console.WriteLine(username);
}