Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello {name}, today is {currentDate:dddd, MMMM dd, yyyy}.");