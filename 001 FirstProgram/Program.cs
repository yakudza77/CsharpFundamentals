// See https://aka.ms/new-console-template for more information
{
    Console.Write("Enter your name:");
    var name = Console.ReadLine(); //var Implicitly typed
    Console.WriteLine($"Hi {name}");
    System.Threading.Thread.Sleep(1000); // pause 1000ms
}