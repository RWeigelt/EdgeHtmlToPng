using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeHtmlToPng
{
    public static class HtmlToPng
    {
        public static void Create(string source, string destination)
        {
            var arguments = $"--headless --disable-gpu --default-background-color=00000000 --window-size=1920,1080 --screenshot=\"{destination}\" \"{source}\"";

            var process = new Process();
            process.StartInfo.FileName = "msedge";
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }
    }
}
