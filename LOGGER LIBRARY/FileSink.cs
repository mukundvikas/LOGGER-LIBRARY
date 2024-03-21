namespace LOGGER_LIBRARY
{
    public class FileSink(string filePath) : ILogSink
    {
        private readonly string filePath = filePath;

        public void LogMessage(LogMessage message)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
               
                writer.WriteLine($"[{message.Level}] [{message.Namespace}] {message.Content}");
            }
        }
    }
}
