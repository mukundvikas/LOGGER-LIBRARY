namespace LOGGER_LIBRARY
{
    public class LogMessage(string content, LogLevel level, string ns)
    {
        public string Content { get; } = content;
        public LogLevel Level { get; } = level;
        public string Namespace { get; } = ns;
    }
}
