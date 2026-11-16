
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a folder path: ");
        string path = Console.ReadLine() ?? "";

        if (Directory.Exists(path))
        {
            ShowFiles(path);
        }
        else
        {
            Console.WriteLine("Directory does not exist.");
        }
    }

    static void ShowFiles(string path)
    {
        Console.WriteLine(Path.GetFileName(
            Path.TrimEndingDirectorySeparator(path)));

        string[] files = Directory.GetFiles(path);

        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }

        string[] folders = Directory.GetDirectories(path);

        foreach (string folder in folders)
        {
            ShowFiles(folder);
        }
    }

    // Reflection Questions

    // 1. What is a base case in recursion?
    // A base case is the condition that stops a recursive
    // method from calling itself again.

    // 2. What happens if a recursive method does not
    // have a base case?
    // It may keep calling itself until the program
    // runs out of stack space and crashes.

    // 3. When might recursion be easier than loops?
    // Recursion can be easier when working with nested
    // structures, such as folders inside other folders.
}


