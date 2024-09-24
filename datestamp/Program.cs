using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: datestamp.exe \"pathtofile\" [creationdate|editdate|opendate] YYYY-MM-DD HH:MM");
            return;
        }

        string filePath = args[0].Trim('"');

        for (int i = 1; i < args.Length; i += 3)
        {
            if (i + 2 < args.Length && DateTime.TryParse($"{args[i + 1]} {args[i + 2]}", out DateTime newDate))
            {
                string command = args[i];

                try
                {
                    switch (command.ToLower())
                    {
                        case "creationdate":
                            File.SetCreationTime(filePath, newDate);
                            Console.WriteLine($"Creation date of '{filePath}' set to {newDate}");
                            break;

                        case "editdate":
                            File.SetLastWriteTime(filePath, newDate);
                            Console.WriteLine($"Last edit date of '{filePath}' set to {newDate}");
                            break;

                        case "opendate":
                            File.SetLastAccessTime(filePath, newDate);
                            Console.WriteLine($"Last access date of '{filePath}' set to {newDate}");
                            break;

                        default:
                            Console.WriteLine($"Invalid command: {command}. Use creationdate, editdate or opendate.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please use YYYY-MM-DD HH:MM");
                return;
            }
        }
    }
}
