using System.Diagnostics;

namespace Mature.CSharp.Lib.Extensions
{
    public class ProcessExtension
    {
        public static bool Start(string fileName, string args, int milliseconds, out string output)
        {
            Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = fileName;
            p.StartInfo.Arguments = args;

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            output = p.StandardOutput.ReadToEnd();
            return p.WaitForExit(milliseconds);
        }
    }
}
