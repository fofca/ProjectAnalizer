using System;
using System.IO;
using System.Reflection;
using System.Runtime;
using LibGit2Sharp;
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
        else if(command.Contains("-git-repo") == true)
        {
            command = command.Replace("-git-repo", string.Empty);
            string fileLocation = Assembly.GetExecutingAssembly().Location;
            fileLocation = Path.GetDirectoryName(fileLocation);
            fileLocation = fileLocation.Replace("\\ProjectAnalizer.Cli\\bin\\Release\\net6.0\\publish", string.Empty) + "\\input\\inputs";
            Repository.Clone(command, fileLocation);
            Console.WriteLine(fileLocation.AllFiles());
            Console.WriteLine(fileLocation.InterfaceFiles());
            Console.WriteLine(fileLocation.ClassFiles());
            Console.WriteLine(fileLocation.EnumFiles());
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            fileLocation = fileLocation.Replace("\\inputs", string.Empty);
            startInfo.Arguments = $"/c D:& cd {fileLocation} & rd /S /q inputs ";
            process.StartInfo = startInfo;
            process.Start();



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

