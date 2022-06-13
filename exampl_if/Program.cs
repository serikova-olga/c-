Console.WriteLine ("Input your name: ");
string username = Console.ReadLine ();

if(username.ToLower() == "alice")
{
    Console.WriteLine("Wow it is Alice!");
}
else
{
    Console.Write("Hello!");
    Console.WriteLine(username);
}