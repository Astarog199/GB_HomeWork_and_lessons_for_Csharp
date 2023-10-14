Console.WriteLine("Enter your username");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Hello, my dear Машенька!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}

