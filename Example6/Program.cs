// Пользуемся условными операторами :)
Console.WriteLine("Enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha") {
    Console.WriteLine("Yes, this is Masha");
}
else {
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
