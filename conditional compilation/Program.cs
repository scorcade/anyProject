// See https://aka.ms/new-console-template for more information
#define TRIAL
#define dev


using System.Diagnostics;

Console.WriteLine("Hello, World!");
Play();

#if TRACL
    Dictionary<string, ConsoleColor> colorMap2 =
                new Dictionary<string, ConsoleColor>
                {
                    ["Error"] = ConsoleColor.Red,
                    ["Warning"] = ConsoleColor.Yellow,
                    ["Information"] = ConsoleColor.Green,
                    ["Verbose"] = ConsoleColor.White
                };
#endif
    {
    Console.WriteLine("DDDDDDDDDD");
    }

[Conditional("dev")]
    static void Play()
    {
        Console.WriteLine("dev");
    }

Console.WriteLine("----------------------");