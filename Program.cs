var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

var source1 = "https://www.example.com";
var source2 = Path.Combine(AppContext.BaseDirectory, "Example2.html");
var source3 = "https://weblogs.asp.net/rweigelt";


var outputFilePath1 = Path.Combine(desktopPath, "Example1.png");
var outputFilePath2 = Path.Combine(desktopPath, "Example2.png");
var outputFilePath3 = Path.Combine(desktopPath, "Example3.png");

HtmlToPng(source1, outputFilePath1);
HtmlToPng(source2, outputFilePath2);
HtmlToPng(source3, outputFilePath3);

return;

void HtmlToPng(string source, string outputFilePath)
{
    var arguments = $"--headless --disable-gpu --default-background-color=00000000 --window-size=1920,1080 --hide-scrollbars --screenshot=\"{outputFilePath}\" \"{source}\"";

    var process = new System.Diagnostics.Process();
    process.StartInfo.FileName = "msedge"; // or "chrome"
    process.StartInfo.Arguments = arguments;
    process.StartInfo.UseShellExecute = true;
    process.Start();
}