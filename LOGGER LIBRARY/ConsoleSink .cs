namespace LOGGER_LIBRARY
{
    public class ConsoleSink : ILogSink   
    {
        public void LogMessage(LogMessage message)
        {
            Console.WriteLine($"[{message.Level}] [{message.Namespace}] - {message.Content}");
        }
    }
}
