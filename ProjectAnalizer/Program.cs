using System.Reflection;


internal class Program
{
        private static void Main(string[] args)
        {
            string command = GetCommandLineArugments(args);
            string fileLocation = Assembly.GetExecutingAssembly().Location;
            fileLocation = Path.GetDirectoryName(fileLocation);
            fileLocation = fileLocation.Replace("\\ProjectAnalizer\\bin\\Release\\net6.0", "");
            fileLocation += "\\ProjectAnalizer.Cli\\bin\\Release\\net6.0\\ProjectAnalizer.Cli.exe";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/c D:& {fileLocation} {command}";
            process.StartInfo = startInfo;
            process.Start();
        }
    public static string GetCommandLineArugments(string[] args)
    {
        string retVal = string.Empty;

        foreach (string arg in args)
            retVal += arg;
        return retVal;
    }
}


