using System.IO;

namespace Pylypeiev.Extensions
{
    public static class StringIOExtensions
    {
        public static void SaveAs(this string str, string fileName, bool append = false)
        {
            using (var tw = new StreamWriter(fileName, append))
            {
                tw.Write(str);
            }
        }

        public static void SaveAs(this string str, FileInfo file, bool append = false)
        {
            using (var tw = new StreamWriter(file.FullName, append))
            {
                tw.Write(str);
            }
        }
    }
}