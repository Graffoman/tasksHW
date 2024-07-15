using System.Diagnostics;
using tasksHW;

string testFilesDir = Path.GetFullPath(@"..\..\..\testFiles");

Console.WriteLine($"Looking for files in {testFilesDir}");
Console.WriteLine();

var stopwatch = Stopwatch.StartNew();
int totalSpaces = await TextAnalyser.CountSpacesInDirectoryAsync(testFilesDir);
stopwatch.Stop();

Console.WriteLine($"Total spaces: {totalSpaces}");
Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");
