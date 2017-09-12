using System.IO;

namespace MyMiner
{
    class FileHandler
    {
        public static void WriteToFile(string filename, string lines)
        {
            File.WriteAllText(@filename, lines);
        }

        public static string ReadFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                return File.ReadAllText(filename);
            }
            else
            {
                return null;
            }
        }
    }
}
