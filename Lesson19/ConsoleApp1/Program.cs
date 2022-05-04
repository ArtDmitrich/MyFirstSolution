using ConsoleApp1;
var maxColumnLength = 30;
var textLength = 5;
var random = new Random();
var maxColumnCount = 50;
var block = new object();
Mutex mutex = new Mutex();

Console.ForegroundColor = ConsoleColor.Green;

for (int i = 0; i < maxColumnCount; i++)
{
    var line = new OneLine(0, maxColumnLength, 3, block);
    line.StartMoveLine();
}




Console.ReadLine();