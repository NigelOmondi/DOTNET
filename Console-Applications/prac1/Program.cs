Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello {name}, today is {currentDate:dddd, MMMM dd, yyyy}.");
Console.WriteLine($"The current time is {currentDate:hh:mm tt}.");
Console.WriteLine($"The current time in 24-hour format is {currentDate:HH:mm}.");
Console.WriteLine($"The current time in UTC is {currentDate.ToUniversalTime():HH:mm}.");
Console.WriteLine("Press any key to exit.");
Console.ReadKey(true); // or just Console.ReadKey() if you want to show the key pressed
Console.WriteLine($"{Environment.NewLine}Thank you for using this program, {name}!");
Console.WriteLine("Goodbye!");