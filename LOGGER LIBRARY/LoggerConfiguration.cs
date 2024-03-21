namespace LOGGER_LIBRARY
{
    public class LoggerConfiguration(Dictionary<LogLevel, List<ILogSink>> sinksByLevel)
    {
        public Dictionary<LogLevel, List<ILogSink>> SinksByLevel { get; } = sinksByLevel;
    }
}
