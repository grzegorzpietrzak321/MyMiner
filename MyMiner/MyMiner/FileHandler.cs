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
            return File.Exists(filename) ? File.ReadAllText(filename) : null;
        }
    }
}
