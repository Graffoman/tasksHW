namespace tasksHW
{
    internal class TextAnalyser
    {
        public static async Task<int> CountSpacesInDirectoryAsync(string directoryPath)
        {
            var files = Directory.GetFiles(directoryPath);
            var tasks = files.Select(CountSpacesInFileAsync);
            var results = await Task.WhenAll(tasks);

            return results.Sum();
        }

        private static async Task<int> CountSpacesInFileAsync(string filePath)
        {
            string content = await File.ReadAllTextAsync(filePath);

            return content.Count(char.IsWhiteSpace);
        }
    }
}
