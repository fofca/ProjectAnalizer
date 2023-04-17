namespace ProjectAnalizer.Core
{
    public static class AnalizerCore
    {

        public static string AllFiles(this String str)
        {
            try
            {
                int info = 0;

                DirectoryInfo di = new(str);

                foreach (var fi in di.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    info++;

                }
                return "Кол-во файлов: " + info.ToString();
            }
            catch (Exception)
            {
                return "Неверно введен путь к папке";
            }
        }
        public static string InterfaceFiles(this String str)
        {
            try
            {
                int info = 0;
                DirectoryInfo di = new(str);
                foreach (var fi in di.GetFiles("*.cs", SearchOption.AllDirectories))
                {
                    var file = File.ReadAllText(fi.Directory + @"\" + fi.Name);
                    if (file.Contains(" internal interface ") == true)
                    {
                        info += 1;
                    }

                }
                return "Кол-во фйлов интерфейсов: " + info.ToString();
            }
            catch (Exception)
            {

                return "Неверно введен путь к папке";
            }

        }
        public static string ClassFiles(this String str)
        {
            try
            {
                int info = 0;
                DirectoryInfo di = new(str);
                foreach (var fi in di.GetFiles("*.cs", SearchOption.AllDirectories))
                {
                    var file = File.ReadAllText(fi.Directory + @"\" + fi.Name);
                    if (file.Contains(" class ") == true)
                    {
                        info += 1;
                    }
                }
                return "Кол-во файлов классов: " + info.ToString();
            }
            catch (Exception)
            {
                return "Неверно введен путь к папке";
            }
        }
        public static string EnumFiles(this String str)
        {
            try
            {
                int info = 0;
                DirectoryInfo di = new(str);
               
                foreach (var fi in di.GetFiles("*.cs", SearchOption.AllDirectories))
                {
                  var file = File.ReadAllText(fi.Directory + @"\" + fi.Name);
                    if (file.Contains(" enum ") == true)
                    {
                        info += 1;
                    }
                }
                return "Кол-во файлов enum: " + info.ToString();
            }
            catch (Exception)
            {
                return "Неверно введен путь к папке";
            }

        }

    }
}