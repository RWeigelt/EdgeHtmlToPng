var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

var source1 = "http://www.example.com";
var source2 = Path.Combine(AppContext.BaseDirectory, "Example2.html");

var outputFilePath1 = Path.Combine(desktopPath, "Example1.png");
var outputFilePath2 = Path.Combine(desktopPath, "Example2.png");

HtmlToPng(source1, outputFilePath1);
HtmlToPng(source2, outputFilePath2);

return;

void HtmlToPng(string source, string outputFilePath)
{
    var arguments = $"--headless --disable-gpu --default-background-color=00000000 --window-size=1920,1080 --screenshot=\"{outputFilePath}\" \"{source}\"";

    var process = new System.Diagnostics.Process();
    process.StartInfo.FileName = "msedge";
    process.StartInfo.Arguments = arguments;
    process.StartInfo.UseShellExecute = true;
    process.Start();
}