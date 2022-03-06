using System.Linq;

namespace Mature.CSharp.Lib.Extensions
{
    public static class FileExtension
    {
        public static string GetDirectoryName(this string exePath)
        {
            int index = exePath.LastIndexOf('\\');
            return exePath.Substring(index + 1);

        }
        public static string GetFileName(this string exePath)
        {
            var name = exePath.Split('\\').LastOrDefault();
            if (string.IsNullOrEmpty(name))
            {
                return "";
            }
            int index = name.LastIndexOf(".");
            return name.Substring(0, index);
        }
    }
}
