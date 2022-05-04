for (int i = 0; i < 20; i++)
{
    _ = Task.Run(async () => await Print(i));
}
Console.ReadKey();

static async Task Print(int column)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    var text = "10";
    var rand = new Random();
    var counter = 0;
    
    do
    {
        object obj = new ();
        lock (obj)
        {
            Console.SetCursorPosition(column, counter++);
            Console.Write(text[rand.Next(0, text.Length)]);
        }
        
        await Task.Delay(30);
        if (counter == 30)
        {
            counter = 0;
            Console.Clear();
        }
    } while (true);    
}
