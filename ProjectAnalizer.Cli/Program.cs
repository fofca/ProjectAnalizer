using System;
using System.IO;
using ProjectAnalizer;
using ProjectAnalizer.Core;

namespace ProjectAnalizer.Cli;
internal class Programh
{
    private static void Main(string[] args)
    {
        string command = GetCommandLineArugmentss(args);
        if (command.Contains("-dir") == true)
        {
            command = command.Replace("-dir", string.Empty);
            string dir = command;
            Console.WriteLine(dir.AllFiles());
            Console.WriteLine(dir.InterfaceFiles());
            Console.WriteLine(dir.ClassFiles());
            Console.WriteLine(dir.EnumFiles());
        }
        else
        {
            Console.WriteLine("Не врерно введена команда или неправильно указан путь");
        }
    }
    public static string GetCommandLineArugmentss(string[] args)
    {
        string retVal = string.Empty;

        foreach (string arg in args)
            retVal += arg;
        return retVal;
    }
}

